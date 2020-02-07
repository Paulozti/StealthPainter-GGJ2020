using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Buttons : MonoBehaviour
{
 
    private void Update()
    {
        if (Input.GetButtonDown("Cancel") && EstadoDeJogo.gameIsPaused)
        {
            Continue();
        }
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        EstadoDeJogo.gameIsPaused = false;
        SceneManager.UnloadSceneAsync(8);
        
    }
    
    public void LoreContinue()
    {
        //EstadoDeJogo.loreOnScreen = false;
        EstadoDeJogo.gameIsPaused = false;

        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(EstadoDeJogo.faseAtual, LoadSceneMode.Single);
        Time.timeScale = 1f;
        SceneManager.UnloadSceneAsync(8);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void NewGame()
    {
        SceneManager.LoadScene(9);
    }

    public void Back()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
