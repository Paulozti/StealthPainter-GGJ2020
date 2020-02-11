using UnityEngine;
using UnityEngine.UI;

public class LanguageControl : MonoBehaviour
{
    public static string newGame;
    public static string menuHowToPlay;
    public static string menuCredits;
    public static string credits;
    public static string exit;
    public static string back;
    public static string howToPlayControl;


    public static void ChangeLanguage(EstadoDeJogo.Language language)
    {
        if(language == EstadoDeJogo.Language.BR)
        {
            newGame = "Novo Jogo";
            menuHowToPlay = "Como jogar";
            menuCredits = "Créditos";
            credits = "" +
                "Jogo desenvolvido na Global Gamejam 2020 \n" +
                "\n" +
                "\n" +
                "Equipe: \n" +
                "\n" +
                "\n" +
                "André Luiz Alvares: Programador; \n" +
                "Fabricio Vigneron: Programador; \n" +
                "Felipe Marinho de Carvalho: Artista de level; \n" +
                "Matheus: Level e Game Design; \n" +
                "Paulo Sergio Soares Junior: Programador; \n" +
                "Tauã Amaro Pereira: Artista líder e Game Design;";
            exit = "Sair";
            back = "Voltar";
            howToPlayControl = "Use AWSD ou SETAS para se mover \n" +
                "\n" +
                "\n" +
                "Use BARRA DE ESPAÇO para interagir com objetos \n" +
                "\n" +
                "\n" +
                "Use O CLIQUE DO MOUSE para resolver o quebra cabeças \n" +
                "\n" +
                "\n" +
                "Use ESC para pausar o game \n" +
                "\n" +
                "\n" +
                "Não seja pego pela luz do guarda!";
        }
        if(language == EstadoDeJogo.Language.EN)
        {
            newGame = "New Game";
            menuHowToPlay = "How to play";
            menuCredits = "Credits";
            credits = "" +
                "Game developed in Global Gamejam 2020 \n" +
                "\n" +
                "\n" +
                "Team: \n" +
                "\n" +
                "\n" +
                "André Luiz Alvares: Programmer; \n" +
                "Fabricio Vigneron: Programmer; \n" +
                "Felipe Marinho de Carvalho: Level Artist; \n" +
                "Matheus: Level Design and Tester; \n" +
                "Paulo Sergio Soares Junior: Programmer; \n" +
                "Tauã Amaro Pereira: Lead Artist and Game Design;";
            exit = "Exit";
            back = "Back";
            howToPlayControl = "Use AWSD or ARROWS KEYS to move \n" +
                "\n" +
                "\n" +
                "Use SPACEBAR to interact with objects \n" +
                "\n" +
                "\n" +
                "Use MOUSE CLICK to resolve puzzle \n" +
                "\n" +
                "\n" +
                "Use ESC to pause the game \n" +
                "\n" +
                "\n" +
                "Don't get caught by the guard's light!";
        }
    }
}
