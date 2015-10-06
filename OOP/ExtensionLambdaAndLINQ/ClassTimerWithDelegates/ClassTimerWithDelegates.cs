/*Using delegates write a class Timer that has can execute certain method at each t seconds.*/

using System;

class ClassTimerWithDelegates
{
    public delegate void ExecuteMethod(string str);
    
    class Timer
    {
        private DateTime next;
        private DateTime start;
        private DateTime end;
        private double seconds;
        private double duration;

        public Timer(double seconds, double duration)
        {
            this.start = DateTime.Now;
            this.seconds = seconds;
            this.duration = duration;
            this.next = start.AddSeconds(seconds);
            this.end = start.AddSeconds(duration);
        }

        public void StartMethod(ExecuteMethod ex, string str)
        {
            while (this.end.Ticks > DateTime.Now.Ticks)
            {
                if (this.next.Ticks < DateTime.Now.Ticks)
                {
                    ex(str);
                    this.next = next.AddSeconds(seconds);
                }
            }
        }
    }

    public static void PrintHello(string str)
    {
        Console.WriteLine(str);
    }


    static void Main()
    {
        ExecuteMethod ex = new ExecuteMethod(PrintHello);
        Timer startMethod = new Timer(3, 15); //The parameters define period and duration in seconds.
        startMethod.StartMethod(ex, "Hi!");
    }
}
