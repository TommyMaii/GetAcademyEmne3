namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment316A
{
    public static readonly Random Random = new Random();
    
    public  void Main(string[] args)
    {
        var filename = "ordliste.txt";
        var words = File.ReadAllLines(filename);
        var filteredWords = getList(words);
        Console.WriteLine(getRandomWord(filteredWords));
    }

    public string getRandomWord(string[] words)
    {
        return words[Random.Next(0, words.Length)];
    }

    public void getWord(string[] words)
    {
        string lastWord = "";

        foreach (var word in words)
        {
            var splitWord = word.Split('\t');
            string printedWord = splitWord[1];

            if (printedWord != lastWord)
            {
                Console.Write(" " + printedWord + " ");
            }
            lastWord = printedWord;
        }
    }
    
    public string[] getList(string[] words)
    {
        string lastWord = "";
        var list = new List<string>();
        foreach (var word in words)
        {
            var splitWord = word.Split('\t');
            string printedWord = splitWord[1];

            if (printedWord != lastWord && printedWord.Length is > 6 and < 10 && !printedWord.Contains('-'))
            {
                list.Add(printedWord);
            }
            lastWord = printedWord;
        }

        return list.ToArray();
    }
}