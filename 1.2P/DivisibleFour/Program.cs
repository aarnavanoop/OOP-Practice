namespace DivisibleFour;

class DivisibleFour
{
    static void Main(string[] args)
    {
        string? userNumber;
        int numberN;
        bool isValid = false;

        do
        {
            Console.WriteLine("Please enter a number as the max range: ");
            userNumber = Console.ReadLine();
            isValid = int.TryParse(userNumber, out numberN);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid integer! ");
            }
        }while(!isValid);

        for(int i = 4; i <= numberN; i+=4)
        {
            if((i % 4 == 0) && (i% 5 != 0))
            {
                Console.WriteLine($"{i} is divisible by 4 and not 5");
            }
        }
    }
}