using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments.Assignment323A;

public class Assignment323A : IAssignment
{
    public void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Hva har du tippet for denne kampen? ");
        var bet = Console.ReadLine();
        Match match = new Match(0,0,true);
        BettingLogic betLogic = new BettingLogic();
        while (match.GetIsRunning())
        {
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            var command = Console.ReadLine();
            match.setMatchStateOnInput(command);
            Console.WriteLine($"Stillingen er {match.GetHomeGoals()}-{match.GetAwayGoals()}.");
        }
        string isBetCorrectText = betLogic.GetBetText(match.GetHomeGoals(), match.GetAwayGoals(), bet);
        Console.WriteLine($"Du tippet {isBetCorrectText}");
    }
}