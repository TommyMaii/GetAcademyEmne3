using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment316A : IAssignment
{
    public static readonly Random Random = new Random();
    
    public void Run() 
    {
        const string filename = "ordliste.txt";
        var words = File.ReadAllLines(filename);
        var filteredWords = getList(words);
        for (var i = 0; i < 200; i++)
        {
            Console.WriteLine(CreateRiddle(filteredWords));
            if (CreateRiddle(filteredWords) == " ")
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

    public string GetRandomWord(string[] words)
    {
        var randomWord = words[Random.Next(0, words.Length)];
        return randomWord;
    }

    public string CreateRiddle(string[] words)
    {
        var randomFirstWord = GetRandomWord(words);
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