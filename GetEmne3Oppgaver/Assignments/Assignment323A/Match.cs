namespace Emne3GetAcademyOppgaver.Assignments.Assignment323A;

public class Match
{
    private int _homeGoals;
    private int _awayGoals;
    private bool _matchIsRunning;

    public Match(int homeGoals,int awayGoals, bool isRunning)
    {
        this._homeGoals = homeGoals;
        this._awayGoals = awayGoals;
        _matchIsRunning = isRunning;
    }

    public bool GetIsRunning()
    {
        return _matchIsRunning;
    }        

    public int GetHomeGoals()
    {
        return _homeGoals;
    }        
    public int GetAwayGoals()
    {
        return _awayGoals;
    }    
    public void SetIsRunning(bool isRunning)
    {
        _matchIsRunning = isRunning;
    }
    
    public void SetHomeGoals(int homeGoals)
    {
        _homeGoals = homeGoals;
    }
    
    public void SetAwayGoals(int awayGoals)
    {
        _awayGoals = awayGoals;
    }
    
    public void setMatchStateOnInput(string command)
    {
        if(command == "X") SetIsRunning(false);
        else if (command == "H") SetHomeGoals(GetHomeGoals()+1);
        else if (command == "B") SetAwayGoals(GetAwayGoals()+1);
    }
}