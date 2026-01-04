namespace ArraysPt1;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayFive = {1,2,2,1};
        bool isPalindrome = Palindrome(arrayFive);
        if (isPalindrome)
        {
            Console.WriteLine("It is a palindrome");
        }
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

        int[,] myArray = new int[3,4] {{1,2,3,4}, {1,1,1,1}, {2,2,2,2}};

        for(int i = 0; i < myArray.GetLength(0); i++)
        {
            for(int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[i,j] + "\t");
            }
            Console.WriteLine();
        }

        Random randomvalue = new Random();
        int randomNumber = randomvalue.Next(1,12);
        List<string> newNames = new List<string>();

        for(int i = 0; i < randomNumber; i++)
        {
            Console.WriteLine($"Add a name to the list: ");
            newNames.Add(Console.ReadLine());
            Console.WriteLine();
        }

        for(int i = 0; i < newNames.Count; i++)
        {
            Console.WriteLine(newNames[i]);
        }

        static bool Palindrome(int[] array)
        {
            if(array.Length < 1)
            {
                return false;
            }

            for(int i = 0; i < array.Length/2; i++)
            {
                if(array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> Merge(List<int> list_a, List<int> list_b)
        {
            if (!IsSorted(list_a) || !IsSorted(list_b))
                {
                    return null;
                }

            List<int> mergedList = new List<int>();
            int i = 0;
            int j = 0;

            while(i < list_a.Count && j < list_b.Count)
            {
                if(list_a[i] <= list_b[j])
                {
                    mergedList.Add(list_a[i]);
                    i++;
                }
                else
                {
                    mergedList.Add(list_b[j]);
                    j++;
                }
            }

            while(i < list_a.Count)
            {
                mergedList.Add(list_a[i]);
                i++;
            }
            while(j < list_b.Count)
            {
                mergedList.Add(list_b[j]);
                i++;
            }
            return mergedList;
        }
    
        static bool IsSorted(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;

        }
        Console.WriteLine("=== Testing Merge Method ===\n");

        // Case 1: Standard Sorted Lists
        List<int> a1 = new List<int> { 1, 2, 2, 5 };
        List<int> b1 = new List<int> { 1, 3, 4, 5, 7 };
        PrintTestResult("Standard Merge", Merge(a1, b1)); 
        // Expected: 1, 1, 2, 2, 3, 4, 5, 5, 7

        // Case 2: One Empty List
        List<int> a2 = new List<int> { 1, 2, 2, 5 };
        List<int> b2 = new List<int> { }; 
        PrintTestResult("Empty List Merge", Merge(a2, b2)); 
        // Expected: 1, 2, 2, 5

        // Case 3: At least one list is UNSORTED
        List<int> a3 = new List<int> { 5, 2, 2, 1 }; // Unsorted
        List<int> b3 = new List<int> { 1, 3, 4, 5, 7 };
        PrintTestResult("Unsorted Input (Should be NULL)", Merge(a3, b3)); 
        // Expected: null

        // Case 4: Both lists empty
        PrintTestResult("Both Empty", Merge(new List<int>(), new List<int>()));
        // Expected: { }

        static void PrintTestResult(string label, List<int> result)
            {
                Console.Write($"{label}: ");
                if (result == null)
                {
                    Console.WriteLine("NULL");
                }
                else if (result.Count == 0)
                {
                    Console.WriteLine("{ empty }");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", result));
                }
            }
        
        static int[] ArrayConversion(int[,] array)
        {
            List<int> convertedArrayList = new List<int>();

            for(int col = 0; col < array.GetLength(1); col++)
            {
                for(int row = 0; row < array.GetLength(0); row++)
                {
                   if(array[row,col]%2 != 0)
                    {
                        convertedArrayList.Add(array[col,row]);
                    }
                }
            }
            return convertedArrayList.ToArray();
        }
            int[,] testGrid = new int[4, 6] {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };

            Console.WriteLine("=== Testing ArrayConversion (Task 10) ===");

            int[] result = ArrayConversion(testGrid);


            Console.WriteLine("Resulting Array:");
            Console.WriteLine(string.Join(", ", result));
    }
}