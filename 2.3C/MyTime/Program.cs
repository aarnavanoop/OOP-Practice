class TestMyTime
{
    static void Main(string[] args)
    {
        MyTime JimTime = new MyTime(23,59,23);
        JimTime.NextMinute();
        Console.WriteLine(JimTime);

        MyTime MaxTime = new MyTime(14,59,23);
        MaxTime.NextMinute();
        Console.WriteLine(MaxTime);

        MyTime AdenTime = new MyTime(23,17,23);
        AdenTime.NextMinute();
        Console.WriteLine(AdenTime);


    }
}


class MyTime
{
    private int _hour;
    private int _minute;
    private int _second;

    public int Hour
    {
        get => _hour;

        set
        {
            if(value < 0 || value > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(Hour), "Hour value must be between 0 and 23.");
            }
            _hour = value;

        }
    }
    public int Minute
    {
        get => _minute;
        set
        {
            if(value < 0 || value > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(Minute), "Minute value must be between 0 and 59");
            }
            _minute = value;

        }
    }
    public int Second
    {
        get => _second;
        set
        {
            if(value < 0 || value > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(Second), "Second value must be between 0 and 59");
            }
            _second = value;

        }
    }

    public MyTime()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;

    }
    public MyTime(int hour, int minute, int second)
    {
        this.Hour = hour;
        this.Minute = minute;
        this.Second = second;
    }

    public void SetTime(int hour, int minute, int second)
    {
        this.Hour = hour;
        this.Minute = minute;
        this.Second = second;  
    }

    public void SetHour(int hour)
    {
        this.Hour = hour;
    }

    public void SetMinute(int minute)
    {
        this.Minute = minute;
    }

    public void SetSecond(int second)
    {
        this.Second = second;
    }

    public override string ToString()
    {
        return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
    }

    public MyTime NextSecond()
    {

        if (this.Second == 59)
        {
            this.Second = 0;
            
            if (this.Minute == 59)
            {
                this.Minute = 0;
                
                if (this.Hour == 23)
                {
                    this.Hour = 0;
                }
                else
                {
                    this.Hour++;
                }
            }
            else
            {
                this.Minute++;
            }
        }
        else 
        {
            this.Second++;
        }
        return this;
    }

    public void NextMinute()
    {
        if(this.Minute == 59)
        {
            if(this.Hour == 23)
            {
                this.Hour = 0;
                this.Minute = 0;
            }
            else
            {
                this.Hour++;
                this.Minute = 0;
            }
        }
        else
        {
            this.Minute ++;
        }
         
    }

}
