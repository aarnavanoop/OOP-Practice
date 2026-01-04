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

    



}
