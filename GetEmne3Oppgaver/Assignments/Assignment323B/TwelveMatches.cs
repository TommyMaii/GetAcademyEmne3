namespace Emne3GetAcademyOppgaver.Assignments.Assignment323B;

public class TwelveMatches
{
    public Match[] CreateMatches(string[] bets)
    {
        var matches = new Match[12];
        for (var i = 0; i < 12; i++)
        {
            matches[i] = new Match(bets[i]);
        }

        return matches;
    }

    public static int GetCorrectCount(Match[] matches)
    {
        int correctCount = 0;
        for (var index = 0; index < matches.Length; index++)
        {
            var match = matches[index];
            var mathNo = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {mathNo}: {match.GetScore()} - {isBetCorrectText}");
        }

        return correctCount;
    }

    public Match GetMatch(Match[] matches, int matchNo)
    {
        var selectedIndex = matchNo - 1;
        var selectedMatch = matches[selectedIndex];
        return selectedMatch;
    }
}