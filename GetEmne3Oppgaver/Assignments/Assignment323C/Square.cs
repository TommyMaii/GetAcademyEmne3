namespace Emne3GetAcademyOppgaver.Assignments.Assignment323C;

public class Square
{
    private const bool IsEmpty = true;
    private bool _isTakenByPlayer1;
    private bool _isTakenByPlayer2;
    private bool _isPlayer1Turn = true;

    public bool getIsEmpty()
    {
        return IsEmpty;
    }
    
    public bool IsTakenByP1()
    {
        if (IsEmpty == true && _isTakenByPlayer1 == true)
        {
            return true;
        }

        return false;
    }

    public void SetOwner(bool isPlayer1Turn)
    {
        if (IsEmpty == false) return;
        if (isPlayer1Turn) _isTakenByPlayer1 = true;
        else _isTakenByPlayer2 = true;
    }
}