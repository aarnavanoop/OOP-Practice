namespace SwitchStatement;
class SwitchStatement
{
    static void Main(string[] args)
    {
        int userNumber;
        bool isValid;
        do
        {
            Console.WriteLine("Please enter a number: ");
            string? userInput = Console.ReadLine();

            isValid = int.TryParse(userInput, out userNumber);

            if(!isValid)
            {
                Console.WriteLine("Please enter an integer! ");
            }
        }while(!isValid);

        switch (userNumber)
        {
            case 1: Console.WriteLine("ONE"); break;
            case 2: Console.WriteLine("TWO"); break;

            default: Console.WriteLine("You must enter either 1 or 2"); break;

        }
        Console.ReadLine();


    }
}