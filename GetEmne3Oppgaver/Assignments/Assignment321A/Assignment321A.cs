using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments.Assignment321;

public class Assignment321A : IAssignment
{
    private CharCounter _charCounter = new CharCounter();
    public void Run()
    {
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            _charCounter.AddText(text);
            _charCounter.ShowCounts();
         
        }
    }
}