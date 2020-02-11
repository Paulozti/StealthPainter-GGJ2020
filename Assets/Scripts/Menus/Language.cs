using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    public Text credits;
    public Text back;
    public Text howToPlay;
    public Text howToPlayControl;
    void Start()
    {
        LanguageControl.ChangeLanguage(EstadoDeJogo.Language.BR);
        if(credits != null)
            credits.text = LanguageControl.credits;
        if(back != null)
            back.text = LanguageControl.back;
        if(howToPlay != null)
            howToPlay.text = LanguageControl.menuHowToPlay;
        if (howToPlayControl != null)
            howToPlayControl.text = LanguageControl.howToPlayControl;
    }
}
