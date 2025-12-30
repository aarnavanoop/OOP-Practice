namespace Microwave;

class Microwave
{
    static void Main(string[] args)
    {
        int counter = 0;
        double totalHeatingTime = 0;
        bool isValid;
        int userNumber = 0;
        string? usersChoice = "";

        bool userChoice = false;

        while (!userChoice)
        {
            do
            {
                Console.WriteLine("What is the heating time of this object?: ");
                string? userInput = Console.ReadLine();

                isValid = int.TryParse(userInput, out userNumber);

                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }while(!isValid);

            counter++;
            totalHeatingTime += userNumber;

            Console.WriteLine("Would you like to add another item?: ");
            usersChoice = Console.ReadLine();
            usersChoice.ToLower().Trim();

            if(counter > 3)
            {
                userChoice = true;
            }
            else if(usersChoice == "no")
            {
                userChoice = true;
            }
        }

        if(counter == 2)
        {
            totalHeatingTime = totalHeatingTime + 0.5*totalHeatingTime;
        }
    }
}