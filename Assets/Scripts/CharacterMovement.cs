using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 8f;
    private bool canPlayerMove = true;

    private AudioSource player_footsteps;
    public float direcao = 0.5f;
    public float axisX, axisY;

    public GameObject player;
    GameObject interactiveGO;
    SpriteRenderer interactive;
    GameObject interactiveEntrar;
    GameObject interactiveDentro;
    private Animator Anim;
    private SpriteRenderer playerSpriteRenderer;
    

    GameObject interactiveChild0;
    GameObject interactiveChild1;
    SpriteRenderer interactiveSR;
    Vector3 exclamationPosition;

    void Start()
    {
        CheckInteraction.onMonalisaStart += StopPlayerMovement;
        CheckInteraction.onMonalisaExit += StartPlayerMovement;
        CheckInteraction.onMonalisaReEnter += StopPlayerMovement;
        CheckInteraction.onPlayerHiding += Hide;
        EstadoDeJogo.playerLight = player.gameObject.transform.GetChild(0).gameObject;
        EstadoDeJogo.playerExclamation = player.gameObject.transform.GetChild(1).gameObject;
        player_footsteps = player.GetComponent<AudioSource>();
        Anim = GetComponent<Animator>();
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
        //interactiveGO = GameObject.Find("Armario");
        //if(interactiveGO != null)
        //{
        //    interactive = interactiveGO.GetComponent<SpriteRenderer>();
        //    interactiveEntrar = GameObject.Find("ArmarioEntrar");
        //    interactiveEntrar.SetActive(false);
        //    interactiveDentro = GameObject.Find("ArmarioDentro");
        //    interactiveDentro.SetActive(false);
        //}
        
    }

    void FixedUpdate()
    {
        if (EstadoDeJogo.quadroAberto)
            return;
    
        verificaDirecao();
        verificaAnimacao();

        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");
        if (axisX != 0 || axisY != 0)
        {
            MoveCharacter(player, new Vector2(axisX, axisY));
            if (!player_footsteps.isPlaying && canPlayerMove)
            {
                player_footsteps.Play();
            }
        }
        else
        {
          player_footsteps.Stop();
        }
    }

    public void verificaDirecao()
    {
        if (axisX > 0) { direcao = 0.5f; }                // valor do eixo positivo está indo para direita
        else if (axisX < 0) { direcao = -0.5f; }          // valor do eixo negativo está indo para esquerda
        transform.localScale = new Vector3(direcao, 0.5f, 0.5f);
    }

    public void verificaAnimacao()
    {
        int antes = Anim.GetInteger("situacao");

        if (axisY < -0.05f)
        {
            Anim.SetInteger("situacao", 1);
            return;
        }
        else
        {
            if (axisY > 0.05f)
            { 
                Anim.SetInteger("situacao", 2);
                return;
            }
        }

        if (axisX > 0.05f || axisX < -0.05f)
        {
            Anim.SetInteger("situacao", 3);
            return;

        }

        if (antes == 3)
            Anim.SetInteger("situacao", 4);
        else
            Anim.SetInteger("situacao", 0);
    }

    public void MoveCharacter(GameObject character, Vector2 direction)
    {
        if (character.CompareTag("Player") && canPlayerMove)
        {
            character.transform.Translate(direction * playerSpeed * Time.deltaTime);
        }
        
    }

    private void StopPlayerMovement()
    {
        canPlayerMove = false;
    }

    private void StartPlayerMovement()
    {
        canPlayerMove = true;
    }

    private void Hide()
    {
        interactiveSR = EstadoDeJogo.interactive.GetComponent<SpriteRenderer>();
        interactiveChild0 = EstadoDeJogo.interactive.transform.GetChild(0).gameObject;
        interactiveChild1 = EstadoDeJogo.interactive.transform.GetChild(1).gameObject;
        
        if (canPlayerMove)
        {
            EstadoDeJogo.playerLight.transform.SetParent(EstadoDeJogo.interactive.transform);
            EstadoDeJogo.playerLight.transform.position = EstadoDeJogo.interactive.transform.position;
            EstadoDeJogo.playerExclamation.gameObject.SetActive(false);
            canPlayerMove = false;
            playerSpriteRenderer.enabled = false;
            interactiveSR.enabled = false;
            interactiveChild0.SetActive(true);
            interactiveChild0.GetComponent<Animator>().Play(0);
            StartCoroutine(DesactivateAnim(false));
        }
        else
        {
            EstadoDeJogo.playerLight.transform.SetParent(player.transform);
            EstadoDeJogo.playerLight.transform.position = player.transform.position;
            EstadoDeJogo.playerExclamation.gameObject.SetActive(true);
            canPlayerMove = true;
            playerSpriteRenderer.enabled = true;
            interactiveChild1.SetActive(false);
            interactiveChild0.SetActive(true);
            interactiveChild0.GetComponent<Animator>().Play(0);
            StartCoroutine(DesactivateAnim(true));
        }
    }
    private void OnDestroy()
    {
        CheckInteraction.onMonalisaStart -= StopPlayerMovement;
        CheckInteraction.onMonalisaExit -= StartPlayerMovement;
        CheckInteraction.onMonalisaReEnter -= StopPlayerMovement;
        CheckInteraction.onPlayerHiding -= Hide;
        player = null;
        interactive = null;
    }

    IEnumerator DesactivateAnim(bool leaving)
    {
        yield return new WaitForSeconds(0.3f);
        interactiveChild0.SetActive(false);
        if (leaving)
        {
            interactiveSR.enabled = true;
        }
        else
        {
            interactiveChild1.SetActive(true);
        }

    }
}
