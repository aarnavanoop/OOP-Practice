namespace TaskFourTwo;

class CatchingTheException
{
    static void Main(string[] args)
    {
        int[] integerArray = {0,1,2,3,4};
        try
        {
            CheckOutOfBounds.ArrayChecker(integerArray);
        }
        catch(IndexOutOfRangeException e)
        {
            //Console.WriteLine("Tried to access an element in the array that is out of range");
            Console.WriteLine(e.Message);
        }
    }
}

class CheckOutOfBounds
{
    public static void ArrayChecker(int[] integerArray)
    {
        int limit = integerArray.Length + 2;
        int varToCheck = integerArray[limit];
    }
}