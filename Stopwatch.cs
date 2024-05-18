namespace StopWatch;

public class Stopwatch
{
    private DateTime _startTime;
    private DateTime _stopTime;
    private Boolean _isRunning;
    private TimeSpan _duration;
    

    public DateTime StartTime
    {
        get => _startTime;
        set => _startTime = value;
    }

    public DateTime StopTime
    {
        get => _stopTime;
        set => _stopTime = value;
    }
    
    public Boolean IsRunning
    {
        get => _isRunning;
        set => _isRunning = value;
    }
    public TimeSpan Duration
    {
        get => _duration;
        set => _duration = value;
    }

    public Stopwatch()
    {
        _startTime = DateTime.MinValue;
        _duration = TimeSpan.Zero;
        _isRunning = false;
    }

    public void start()
    {
        if (_isRunning)
        {
            Console.WriteLine("This chronometer is already running. Try stopping it.");
        }
        else
        {
            _startTime = DateTime.Now;
            _isRunning = true;
        }
        
    }

    public void stop()
    {
        if (!_isRunning)
        {
            Console.WriteLine("This chronometer never started running. Try starting it before.");
        }
        else
        {
            _stopTime = DateTime.Now;
            _duration = _stopTime - _startTime;
            Console.WriteLine("Your StopWatch successfully stopped. \nTime: "+ _duration);
            _isRunning = false;
        }
    }
}