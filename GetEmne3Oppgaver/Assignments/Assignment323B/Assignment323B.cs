namespace Emne3GetAcademyOppgaver.Assignments.Assignment323B;

public class Assignment323B
{
    public void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        var betsText = Console.ReadLine();
        var bets = betsText.Split(',');
        TwelveMatches twelveMatches = new TwelveMatches();
        var matches = twelveMatches.CreateMatches(bets);

        while (true)
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            var command = Console.ReadLine();
            if (command == "X") break;
            var matchNo = Convert.ToInt32(command);
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            var team = Console.ReadLine();
            twelveMatches.GetMatch(matches, matchNo).AddGoal(team == "H");
            var correctCount = TwelveMatches.GetCorrectCount(matches);
            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}