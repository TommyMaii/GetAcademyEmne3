namespace Emne3GetAcademyOppgaver.Assignments.Assignment323A;

public class BettingLogic
{
    public string GetBetText(int homeGoals, int awayGoals, string bet)
    {
        var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
        var isBetCorrect = bet.Contains(result);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
        return isBetCorrectText;
    }
}