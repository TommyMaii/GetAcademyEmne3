using GetEmne3Oppgaver;

namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315A : IAssignment
{
    public void Run()
    {
        var random = new Random();
        var number = random.Next(1, 100);
        var guessed = false;
        var guessAttempts = 0;

        while (!guessed)
        {
            Console.WriteLine("Gjett nummeret!");
            int guessedNumber = int.Parse(Console.ReadLine());
            guessAttempts++;

            if (number > guessedNumber)
            {
                Console.WriteLine("Nummeret er større");
            }
            else if (number < guessedNumber)
            {
                Console.WriteLine("Nummeret er lavere");
            }
            else if (number == guessedNumber)
            {
                guessed = true;
                Console.WriteLine($"Gratulerer! Du brukte {guessAttempts} forsøk");
            }

        }

    }
}