using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315C : IAssignment
{
        public void Run()
        {
        
            Console.WriteLine(reverseText("Terje"));
        }
    
        static string reverseText(string text)
        {
            var characters = text.ToCharArray().Reverse();
            return new string(characters.ToArray());
            
            // var characters = text.ToCharArray();
            // Array.Reverse(characters);
            // return new string(characters);
        }
}

// splitText.ToString(); Hva gjør tostring?
