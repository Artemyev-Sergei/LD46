
public abstract class SquadController : ITurnTaker
{
    protected int squadsMoved = 0;

    public abstract void TakeTurn();
    public bool IsTurnFinished()
    {
		if (this.squadsMoved >= 4)
		{
			this.squadsMoved = 0;
			return true;
		}
		else
		{
			return false;
		}
	}
}
