namespace ArraysPt1;

class Program
{
    static void Main(string[] args)
    {
        double[] arrayOne = new double[10];
        arrayOne[0] = 1.0;
        arrayOne[1] = 1.1;
        arrayOne[2] = 1.2;
        arrayOne[3] = 1.3;
        arrayOne[4] = 1.4;
        arrayOne[5] = 1.5;
        arrayOne[6] = 1.6;
        arrayOne[7] = 1.7;
        arrayOne[8] = 1.8;
        arrayOne[9] = 1.9;

        for(int i = 0; i < arrayOne.Length; i++)
        {
            Console.WriteLine($"The element at index {i} is {arrayOne[i]:0.0}");
        }
        
        int[] studentArray = { 87,68,94,100,83,78,85,91,76,87};
        int total = 0;

        for(int i = 0; i < studentArray.Length; i++)
        {
            total += studentArray[i];
        }

        Console.WriteLine($"The total marks for the student is: {total}");
        Console.WriteLine($"This consists of {studentArray.Length} marks");
        Console.WriteLine($"The average mark is {total/studentArray.Length}");

        string[] studentNames = new string[6];
        string? userInput = "";

        for(int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine($"What is the name of the student at position {i + 1}?");
            userInput = Console.ReadLine();
            studentNames[i] = userInput;
        }

        for(int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}: {studentNames[i]}");
        }

        int[] integerArray = new int[5];
        string userStringInput = "";
        int userIntInput = 0;

        int currentLargest;
        int currentSmallest;

        for(int i = 0; i < integerArray.Length; i++)
        {
            Console.WriteLine("Please enter an integer: ");
            userStringInput = Console.ReadLine();
            //No validation here as it has been done numerous times in previous tasks,
            //keeping simplicity here and focusing on key concepts instead
            int.TryParse(userStringInput, out userIntInput);
            integerArray[i] = userIntInput;
        }

        currentLargest = integerArray[0];
        currentSmallest = integerArray[0];
        for(int i = 1; i < integerArray.Length; i++)
        {
            if(currentLargest < integerArray[i])
            {
                currentLargest = integerArray[i];
            }

            if(currentSmallest > integerArray[i])
            {
                currentSmallest = integerArray[i];
            }
            Console.WriteLine($"Element: {integerArray[i]}");
        }
        
        Console.WriteLine($"The largest integer is: {currentLargest}");
        Console.WriteLine($"The smallest integer is: {currentSmallest}");
    
    }
}