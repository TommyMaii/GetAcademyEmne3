namespace GetEmne3Oppgaver.Assignments.Assignment321C;

public class CoinModel
{
    private readonly int _value;
    private readonly int _count;

    public CoinModel(int value, int count)
    {
        _value = value;
        _count = count;
    }

    public int ReturnSum()
    {
        return _value * _count;
    }
}