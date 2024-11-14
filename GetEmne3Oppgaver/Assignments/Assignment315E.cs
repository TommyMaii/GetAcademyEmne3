namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315E
{
    public static void Main(string[] args)
    {
        var numbers = returnNumbers(1000, 2000, 7);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static int[] returnNumbers(int startValue, int endValue, int difference)
    {
        int count = 0;
        int[] numbers = new int[(endValue-startValue)/difference];
        for (int i = 0; i < numbers.Length; i++)
        {
            count++;
            numbers[i] = startValue + (difference * count);
        }
        return numbers;
    }
}