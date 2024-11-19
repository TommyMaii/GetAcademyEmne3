namespace Emne3GetAcademyOppgaver.Assignments.Assignment321;

public class CharCounter
{
    private static readonly int _range = 250;
    readonly int[] _counts = new int[_range];

    public void ShowCounts()
    {
        for (var i = 0; i < _range; i++)
        {
            if (_counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + _counts[i]);
            }
        }
    }

    public void AddText(string text)
    {
        foreach (var character in text ?? string.Empty)
        {
            _counts[(int)character]++;
        }
    }
}