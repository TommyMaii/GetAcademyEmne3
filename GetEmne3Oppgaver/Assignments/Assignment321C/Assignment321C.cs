using Emne3GetAcademyOppgaver.Assignments;

namespace GetEmne3Oppgaver.Assignments.Assignment321C;

public class Assignment321C : IAssignment
{
    
    public void Run()
    {
        CalculateSum calculateSum = new CalculateSum([        
            new (1,7),
            new (5,7),
            new (10,7),
            new (20,7)]);
        Console.WriteLine(calculateSum.Calculate().ToString());
    }
    

}