namespace Emne3GetAcademyOppgaver.Assignments.Assignment323B;

public class Match
{
    private int _homeGoals;
    private int _awayGoals;
    private string _bet;
    private bool _matchIsRunning;

    public Match(string bet)
    {
        _bet = bet;
        _matchIsRunning = true;
    }
    public string GetScore()
    {
        return _homeGoals + "-" + _awayGoals;
    }
    public void AddGoal(bool isHome)
    {
        if (isHome)
        {
            _homeGoals++;
        }
        else
        {
            _awayGoals++;
        }
    }

    public bool IsBetCorrect()
    {
        var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
        var isBetCorrect = _bet.Contains(result);
        return isBetCorrect;
    }

    // public void setMatchStateOnInput(string command)
    // {
    //     if(command == "X") SetIsRunning(false);
    //     else if (command == "H") SetHomeGoals(GetHomeGoals()+1);
    //     else if (command == "B") SetAwayGoals(GetAwayGoals()+1);
    // }
}