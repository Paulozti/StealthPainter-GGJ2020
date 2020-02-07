using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorDePuzzle : MonoBehaviour
{
    public GameObject[] quadros;
    MatrizQuadro quadroAtual;
    public Texture[] quadroAtualTexture;
    public RawImage quadroAtualImage;
    public GameObject completeText;

    void OnEnable()
    {
        for (int i = 0; i < quadros.Length; i++)
        {
            bool ativo = i == EstadoDeJogo.faseAtual;
            
            if (ativo)
            {
                quadroAtual = quadros[i].GetComponent<MatrizQuadro>();
                quadroAtualImage.texture = quadroAtualTexture[i];
            }
                
                

            quadros[i].SetActive(ativo);
        }
    }
    
    void OnDisable()
    {
        EstadoDeJogo.quadroAberto = false;
    }
    
    void Update()
    {
        if (quadroAtual)
        {
            if (quadroAtual.resolvido) 
            {
                EstadoDeJogo.podeProsseguirFase = true;
                completeText.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            quadroAtual.resolvido = true;
        }
    }
}
