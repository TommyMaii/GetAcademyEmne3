using GetEmne3Oppgaver.Assignments.Assignment321C;

namespace Emne3GetAcademyOppgaver.Assignments;

public class CalculateSum
{

    private readonly CoinModel[] Coins = [];
    public CalculateSum(CoinModel[] Coins)
    {
        this.Coins = Coins;
    }
    public int Calculate()
    {
        int sum = 0;
        foreach (var coin in Coins)
        {
            sum += coin.ReturnSum();
        }
        return sum;
    }
}