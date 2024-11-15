namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315C
{
        public static void Run()
        {
        
            Console.WriteLine(reverseText("Terje"));
        }
    
        static string reverseText(string text)
        {
            char[] splitText = text.ToCharArray();
            Array.Reverse(splitText);
            return new string(splitText);
        }
}

// splitText.ToString(); Hva gjør tostring?
