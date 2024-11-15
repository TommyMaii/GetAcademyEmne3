namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315H
{
    static void Run()
    {
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            int range = 250;
            text = Console.ReadLine().ToLower();
            var counts = countCharacters(text , 250);
            printText(counts, range, text.Length);
        }
    }

    static int[] countCharacters(string text, int range)
    {
        var counts = new int[range];
        foreach (var character in text)
        {
            counts[(int)character]++;
        }
        
        return counts;
    }

    static void printText(int[] counts, int range, double length)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] > 0)
            {
                double textLength = length;
                double percent = counts[i] / textLength * 100.0;
                var character = (char)i;
                Console.WriteLine(character + " - " + counts[i] + " " + percent.ToString("00") + " % ");
            }
        }
    }
}