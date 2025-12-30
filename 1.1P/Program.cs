namespace MyProgram;

class IfStatement
{
    static void Main(string[] args)
    {
        int userNumber = 0;
        bool isValid;

        do
        {
            Console.WriteLine("Enter the number: "); 
            string? userInput = Console.ReadLine();

            isValid = int.TryParse(userInput, out userNumber);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }while(!isValid);

        if(userNumber == 1)
        {
            Console.WriteLine("ONE");
        }
        else if(userNumber == 2)
        {
            Console.WriteLine("TWO");
        }
        else if(userNumber == 3)
        {
            Console.WriteLine("THREE");
        }
        else if(userNumber == 4)
        {
            Console.WriteLine("FOUR");
        }
        else if(userNumber == 5)
        {
            Console.WriteLine("FIVE");
        }
        else if(userNumber == 6)
        {
            Console.WriteLine("SIX");
        }
        else if(userNumber == 7)
        {
            Console.WriteLine("SEVEN");
        }
        else if(userNumber == 8)
        {
            Console.WriteLine("EIGHT");
        }
        else if(userNumber == 9)
        {
            Console.WriteLine("NINE");
        }
        else
        {
            Console.WriteLine("Not within range");
        }
    }

}