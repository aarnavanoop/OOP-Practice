class TestMyTime
{
static void Main(string[] args)
{
    Console.WriteLine("=== Testing MyTime Class ===\n");

    // TEST 1: Constructor & ToString
    // We start just before midnight to test the rollover logic immediately
    Console.WriteLine("Test 1: Create valid time (23:59:58)");
    MyTime t = new MyTime(23, 59, 58);
    Console.WriteLine($"Start Time: {t}"); // Expected: 23:59:58

    // TEST 2: Exception Handling
    // We try to break the code intentionally to ensure safety works
    Console.WriteLine("\nTest 2: Attempting to create invalid time (25:00:00)");
    try
    {
        MyTime badTime = new MyTime(25, 0, 0);
        Console.WriteLine("ERROR: Object was created! Validation failed.");
    }
    catch (ArgumentOutOfRangeException e)
    {
        Console.WriteLine($"SUCCESS: Correctly caught error: {e.Message}");
    }

    // TEST 3: NextSecond Rollover (The "New Year's Eve" test)
    // 23:59:58 -> 23:59:59 -> 00:00:00
    Console.WriteLine("\nTest 3: Testing NextSecond Rollover");
    t.NextSecond();
    Console.WriteLine($"Step 1 (+1s): {t}"); // Expected: 23:59:59
    t.NextSecond();
    Console.WriteLine($"Step 2 (+1s): {t}"); // Expected: 00:00:00 (CRITICAL CHECK)

    // TEST 4: PreviousSecond Rollover (Reverse logic)
    // 00:00:00 -> 23:59:59
    Console.WriteLine("\nTest 4: Testing PreviousSecond Rollover");
    t.PreviousSecond();
    Console.WriteLine($"Result: {t}"); // Expected: 23:59:59

    // TEST 5: PreviousMinute
    // 23:59:59 -> 23:58:59
    Console.WriteLine("\nTest 5: Testing PreviousMinute");
    t.PreviousMinute();
    Console.WriteLine($"Result: {t}"); // Expected: 23:58:59

    // TEST 6: PreviousHour
    // 23:58:59 -> 22:58:59
    Console.WriteLine("\nTest 6: Testing PreviousHour");
    t.PreviousHour();
    Console.WriteLine($"Result: {t}"); // Expected: 22:58:59

    // TEST 7: Method Chaining
    // Proves that 'return this' allows multiple actions in one line
    Console.WriteLine("\nTest 7: Testing Method Chaining");
    // Logic: 22:58:59 -> (+1h) 23:58:59 -> (+1m) 23:59:59 -> (+1s) 00:00:00
    t.NextHour().NextMinute().NextSecond(); 
    Console.WriteLine($"Result after chaining (+1h, +1m, +1s): {t}"); // Expected: 00:00:00

    Console.WriteLine("\n=== Test Complete ===");
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

    public MyTime NextMinute()
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
         
        return this;
    }

    public MyTime NextHour()
    {
        if(this.Hour == 23)
        {
            this.Hour = 0;
        }
        else
        {
            this.Hour++;
        }

        return this;
    }

    public MyTime PreviousSecond()
    {
        if (this.Second == 0)
        {
            this.Second = 59;
            if (this.Minute == 0)
            {
                this.Minute = 59;
                if (this.Hour == 0)
                {

                    this.Hour = 23;
                }
                else
                {
                    this.Hour--;
                }
            }
            else
            {
                this.Minute--;
            }
        }
        else
        {
            this.Second--;
        }
        return this;
    }

    public MyTime PreviousMinute()
    {
        if (this.Minute == 0)
        {
            this.Minute = 59;
            if (this.Hour == 0)
            {
                this.Hour = 23;
            }
            else
            {
                this.Hour--;
            }
        }
        else
        {
            this.Minute--;
        }
        return this;
    }

    public MyTime PreviousHour()
    {
        if(this.Hour == 0)
        {
            this.Hour = 23;
        }
        else
        {
            this.Hour --;
        }
        return this;
    }

}
