using UnityEngine;
using UnityEngine.SceneManagement;

public class EstadoDeJogo : MonoBehaviour
{
    public enum Quadros {
        Monalisa = 0,
    }

    public AudioSource playerSteps;
    public AudioSource backgroundmusic;

    public static bool quadroAberto;
    public static bool podeProsseguirFase;
    public static int faseAtual;
    public static int faseAtualBI;
    public static bool gameIsPaused;
    public static bool gameIsOver;
    //public static bool loreOnScreen;
    public static bool levelIsStarting;
    public static GameObject interactive;
    public static GameObject playerLight;
    public static GameObject playerExclamation;
    public static bool returnMusic = false;
    public enum Language
    {
        EN,
        BR
    };
    public static Language gameLanguage = Language.BR;

    private void Start()
    {
        gameIsPaused = false;
        gameIsOver = false;
        levelIsStarting = true;
        //loreOnScreen = true;
    }
    public void Update()
    {
        if (Input.GetButtonDown("Cancel") && !gameIsPaused)
        {
            playerSteps.Stop();
            backgroundmusic.Pause();
            gameIsPaused = true;
            Time.timeScale = 0f;
            SceneManager.LoadSceneAsync(8, LoadSceneMode.Additive);
        }
        if (quadroAberto)
        {
            playerSteps.Stop();
        }
        if (returnMusic)
        {
            backgroundmusic.UnPause();
            returnMusic = false;
        }
    }
}
