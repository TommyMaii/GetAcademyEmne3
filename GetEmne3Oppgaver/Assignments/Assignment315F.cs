namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315F
{
    public static int[] numbers = [1, 2, 3, 4, 0, 5, 6, 7, 8];
    
    public static void Run()
    {
        Console.WriteLine($"{numbers[0] + " " + numbers[1] + " " + numbers[2]}");
        Console.WriteLine($"{numbers[3] + " " +  numbers[4] + " " + numbers[5]}");
        Console.WriteLine($"{numbers[6] + " " + numbers[7] + " " + numbers[8]}");
        string Input = Console.ReadLine();
    }

    static void moveLeft()
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int index = Array.IndexOf(numbers, 0);
            numbers[index] = numbers[index - 1];
        }
    }
    //WHILE LOOOP 
    //LEFT RIGHT TOP BOTTOM
    //SOMETHING LIKE THIS
    //JUST AN EXAMPLE NOT FLESHED OUT
}