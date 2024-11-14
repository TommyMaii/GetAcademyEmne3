namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315A
{
    public static void Main(string[] args)
    {
        var random = new Random();
        var number = random.Next(1, 100);
        bool guessed = false;
        int counter = 0;

        while (!guessed)
        {
            Console.WriteLine("Gjett nummeret!");
            int guessedNumber = int.Parse(Console.ReadLine());
            counter++;

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
                Console.WriteLine($"Gratulerer! Du brukte {counter} forsøk");
            }

        }

    }
}