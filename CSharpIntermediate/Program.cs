namespace CsharpIntermediate;

class Program
{
    static void Main(string[] args)
    {
        var stopwatch = new StopWatch();

        for (var i = 0; i < 2; i++)
        {
            for (var j = 0; j <= 1000; j++)
            {
                Thread.Sleep(1);
            }
        }

        stopwatch.Start(DateTime.Now);
        stopwatch.Stop(DateTime.Now);

        Console.WriteLine(stopwatch.GetInterval().ToString());
        Console.ReadLine();
    }
}

public class StopWatch
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    private bool running = false;

    public void Start(DateTime start)
    {
        if (!running)
        {
            StartTime = start;
            running = true;
        }
        else
        {
            throw new InvalidOperationException("Stop watch is already running");
        }
    }

    public void Stop(DateTime stop)
    {
        if (running)
        {
            EndTime = stop;
            running = false;
        }
    }

    public TimeSpan GetInterval()
    {
        var duration = EndTime - StartTime;
        return duration;
    }
}