using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Language : MonoBehaviour
{
    private List<GameObject> textList;
    private int count = 0;

    public GameObject newGame_0;
    public GameObject howToPlay_1;
    public GameObject menuCredits_2;
    public GameObject credits_3;
    public GameObject exit_4;
    public GameObject back_5;
    public GameObject howToPlayControl_6;
    public GameObject lore_7;
    public GameObject pressHere_8;
    public GameObject closePainting_9;
    public GameObject repairComplete_10;
    public GameObject paused_11;
    public GameObject continueText_12;
    public GameObject restart_13;
    public GameObject congratulation_14;
    public GameObject congratzRestore_15;

    private void checkNull()
    {
        textList.Add(newGame_0);
        textList.Add(howToPlay_1);
        textList.Add(menuCredits_2);
        textList.Add(credits_3);
        textList.Add(exit_4);
        textList.Add(back_5);
        textList.Add(howToPlayControl_6);
        textList.Add(lore_7);
        textList.Add(pressHere_8);
        textList.Add(closePainting_9);
        textList.Add(repairComplete_10);
        textList.Add(paused_11);
        textList.Add(continueText_12);
        textList.Add(restart_13);
        textList.Add(congratulation_14);
        textList.Add(congratzRestore_15);
    }

    void Start()
    {
        textList = new List<GameObject>();
        checkNull();
        LanguageControl.ChangeLanguage(EstadoDeJogo.gameLanguage);
        foreach (GameObject g in textList)
        {
            setLanguage(g, LanguageControl.textLanguages[count]);
            count++;
        }
    }

    private void setLanguage(GameObject changeText, string languageText)
    {
        if(changeText != null)
        {
            changeText.GetComponent<Text>().text = languageText;
        }
    }
}
