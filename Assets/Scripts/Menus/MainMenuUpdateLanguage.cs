using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUpdateLanguage : MonoBehaviour
{
    public Text newGame;
    public Text howTo;
    public Text credit;
    public Text exit;
    public Toggle EN;
    public Toggle BR;

    public void UpdateLanguage()
    {
        newGame.text = LanguageControl.textLanguages[0];
        howTo.text = LanguageControl.textLanguages[1];
        credit.text = LanguageControl.textLanguages[2];
        exit.text = LanguageControl.textLanguages[4];
    }
    private void Update()
    {
        if(EstadoDeJogo.gameLanguage == EstadoDeJogo.Language.BR)
        {
            BR.isOn = true;
            EN.isOn = false;
        }
        else if(EstadoDeJogo.gameLanguage == EstadoDeJogo.Language.EN)
        {
            BR.isOn = false;
            EN.isOn = true;
        }
    }

}
