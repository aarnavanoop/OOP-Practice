namespace TaskFourOne;

class CatchTheError
{
    static void Main(string[] args)
    {
        string userInput = null;
        int checkedLength;
        try
        {
            checkedLength = ThrowTheError.CheckLength(userInput);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("The string you provided(userInput) was null, the check length method does not work on a null value");
        }
    }
}

class ThrowTheError
{
    public static int CheckLength(string userInput)
    {   
        int checkedLength = userInput.Length;
        return checkedLength;
    }
  
}

