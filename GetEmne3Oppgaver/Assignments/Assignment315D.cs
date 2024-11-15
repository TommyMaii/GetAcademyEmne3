using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315D : IAssignment
{
    static string[] vowelList = ["a", "e", "i", "o", "u", "y", "æ", "ø" , "å"];
    
    public void Run()
    {
        Console.Write("Skriv en tekst! Så teller jeg ordene ");
        string input = Console.ReadLine().ToLower();
        Console.WriteLine(countWords(input));
        Console.WriteLine(input.Length);
        // Console.WriteLine(countVowels(input));
    }

    static string[] splitText(string text)
    {
        return text.Split(' ');
    }
    static int countWords(string inputText)
    {
        string[] text = splitText(inputText);
        return text.Length;
    }

    // static int countVowels(string inputText)
    // {
    //     int count = 0;
    //     int vowelCounter = 0;
    //     string[] text = splitText(inputText);
    //     for (int i = 0; i < text.Length; i++)
    //     {
    //         var splitText = text[i].Split();
    //         for (int j = 0; j < splitText.Length;)
    //         {
    //             if (splitText[j].Split().Equals(vowelList[count]))
    //             {
    //                 vowelCounter++;
    //             }
    //             if (count == vowelList.Length) {count = 0; j++;};
    //             count++;
    //         }
    //     }
    //
    //     return vowelCounter;
    // }
}