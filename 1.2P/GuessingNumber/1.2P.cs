namespace GuessingNumber;

class GuessingNumber
{
    static void Main(string[] args)
    {
        //int number = 5;
        string? userGuess = "";
        int userNumber = 0;
        bool validGuess = false;
        bool isValid;
        bool correctGuess = false;

        string user1string;
        int user1Number;
        bool validNumber = false;
        do
        {
            Console.WriteLine("What is the number you want the second player to guess?: ");
            user1string = Console.ReadLine();

            validNumber = int.TryParse(user1string, out user1Number);

            if (!validNumber)
            {
                Console.WriteLine("Please enter an integer! ");

            }

        }while(!validNumber);

        while (!correctGuess)
        {
            do
            {
                Console.WriteLine("Please enter a number to guess: ");
                userGuess = Console.ReadLine();
                isValid = int.TryParse(userGuess, out userNumber);

                if (!isValid)
                {
                    Console.WriteLine("You have to enter an integer! ");
                }
            }while(!isValid);

            if(userNumber < 1)
            {
                Console.WriteLine("Please enter a number betwen 1 and 10!");
            }
            else if(userNumber > 10)
            {
                Console.WriteLine("Please enter a number betwen 1 and 10!");
            }
  
            if(userNumber == user1Number)
            {
                Console.WriteLine("Congrats you guessed the number!");
                Console.WriteLine($"The number was {userNumber}");
                correctGuess = true;
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }

        }

    }
}