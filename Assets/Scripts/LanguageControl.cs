using UnityEngine;
using UnityEngine.UI;

public class LanguageControl : MonoBehaviour
{
    public static string[] textLanguages;

    public static void ChangeLanguage(EstadoDeJogo.Language language)
    {
        textLanguages = new string[16];

        if (language == EstadoDeJogo.Language.BR)
        {
            textLanguages[0] = "Novo Jogo";
            textLanguages[1] = "Como jogar";
            textLanguages[2] = "Créditos";
            textLanguages[3] = "" +
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
            textLanguages[4] = "Sair";
            textLanguages[5] = "Voltar";
            textLanguages[6] = "Use AWSD ou SETAS para se mover \n" +
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
            textLanguages[7] = "O museu foi atacado ontem...\n" +
                               "Pinturas importantes foram vandalizadas...\n" +
                               "Como eu sou um reparador, não posso simplesmente " +
                               "deixar as coisas como estão.\n" +
                               "Eu tenho que repara-las!\n" +
                               "\n" +
                               "\n" +
                               "Diario do restaurador\n" +
                               "31 de Janeiro de 2020.";
            textLanguages[8] = "Pressione aqui para jogar";
            textLanguages[9] = "Aperte a BARRA DE ESPAÇO\n" +
                               "para fechar a pintura.";
            textLanguages[10] = "Você completou a reparação.\n" +
                                "Encontre uma saída!";
            textLanguages[11] = "Pausado";
            textLanguages[12] = "Continuar";
            textLanguages[13] = "Recomeçar";
            textLanguages[14] = "PARABÉNS";
            textLanguages[15] = "Você restaurou todas as pinturas!";
        }
        if(language == EstadoDeJogo.Language.EN)
        {
            textLanguages[0] = "New Game";
            textLanguages[1] = "How to play";
            textLanguages[2] = "Credits";
            textLanguages[3] = "" +
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
            textLanguages[4] = "Exit";
            textLanguages[5] = "Back";
            textLanguages[6] = "Use AWSD or ARROWS KEYS to move \n" +
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
            textLanguages[7] = "The museum was attacked yesterday...\n" +
                               "Importante paintings got vandalized...\n" +
                               "Since I'm a restorer, I just can't leave\n" +
                               "things like this.I gotta repair them!\n" +
                               "\n" +
                               "\n" +
                               "Restorer's diary\n" +
                               "January 31, 2020.";
            textLanguages[8] = "Press here to play";
            textLanguages[9] = "Press SPACE to " +
                               "close the painting";
            textLanguages[10] = "You completed the repair.\n" + 
                                "Find an exit!";
            textLanguages[11] = "Paused";
            textLanguages[12] = "Continue";
            textLanguages[13] = "Restart";
            textLanguages[14] = "CONGRATULATIONS";
            textLanguages[15] = "You've restored all the paintings!";
        }
    }

    public void PT_BR()
    {
        EstadoDeJogo.gameLanguage = EstadoDeJogo.Language.BR;
        ChangeLanguage(EstadoDeJogo.Language.BR);
    }

    public void EN_US()
    {
        EstadoDeJogo.gameLanguage = EstadoDeJogo.Language.EN;
        ChangeLanguage(EstadoDeJogo.Language.EN);
    }
}


