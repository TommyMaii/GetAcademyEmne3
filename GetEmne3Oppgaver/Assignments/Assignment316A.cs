namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment316A
{
    public static readonly Random Random = new Random();
    
    public  void Main(string[] args)
    {
        var filename = "ordliste.txt";
        var words = File.ReadAllLines(filename);
        var filteredWords = getList(words);
        for (int i = 0; i < 200; i++)
        {
            Console.WriteLine(createRiddle(filteredWords));
            if (createRiddle(filteredWords) == " ")
            {
                i--;
            }
        }
        
    }

    //Data testing Function
    public void iterateThroughList(string[] words)
    {
        foreach (var word in words.Take(200))
        {
            Console.WriteLine(word);
        }
    }

    public string getRandomWord(string[] words)
    {
        var randomWord = words[Random.Next(0, words.Length)];
        return randomWord;
    }

    public string createRiddle(string[] words)
    {
        var randomFirstWord = getRandomWord(words);
        var lastPartOfWord = randomFirstWord.Substring(randomFirstWord.Length - 3);
        var riddleList = new List<string>();
        
        foreach (var word in words)
        {
            if (lastPartOfWord == word.Substring(0, 3))
            {
                return randomFirstWord + " " + lastPartOfWord + " " + word; 
            }
        }

        return "";
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