namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315G
{
    static void Main(string[] arguments)
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine().ToLower();
            foreach (var character in text)
            {
                counts[(int)character]++;
            }
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    double textLength = text.Length;
                    double percent = counts[i] / textLength * 100.0;
                    ;
                    Console.WriteLine(counts[i]);
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i] + " " + percent.ToString("00") + " % ");
                }
            }
        }
    }
}