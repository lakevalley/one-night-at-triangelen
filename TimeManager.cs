namespace One_night_at_Triangelen;

public class TimeManager
{
    private int _timeLeft;

    // Constructor med in-parameter för tid, ex: 60 (minuter)
    public TimeManager()
    {
        _timeLeft = 60;
    }

    // Varje DecreaseTime() drar av -5 minuter på timeLeft
    public void DecreaseTime()
    {
        _timeLeft -= 5;
    }

    public void GetTimeLeft()
    {
        Console.WriteLine($"Time left: {_timeLeft} minutes.");
    }

    public void IsTimeUp()
    {
        if (_timeLeft <= 0)
        {
            Console.WriteLine("Time is up, you hear the train drive off in the distance.. Game over");
            Environment.Exit(0);
        }
    }
}