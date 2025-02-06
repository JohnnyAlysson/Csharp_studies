internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Simple CLI Guessing game");

        int choice = 100;
        Random rnd = new Random();
        int bot = rnd.Next(1, 100);

        while (choice != 0)
        {
            try
            {
                if (choice == bot)
                {
                    Console.WriteLine("CONGRATULATIONS YOU WON");
                    break;
                }
                else if (choice > 100)
                {
                    Console.WriteLine("the number must be lower than 100");
                }
                else if (choice < 1)
                {
                    Console.WriteLine("the number must be higher than 1");
                }
                else if (choice < 1)
                {
                    Console.WriteLine("the number must be higher than 1");
                }
                else if (choice < bot)
                {
                    Console.WriteLine("Bot has choosen a higher number");
                }
                else if (choice > bot)
                {
                    Console.WriteLine("Bot has choosen a lower number");
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");

                }
                Console.WriteLine("Type a number from 1 to 100 or zero to exit");
                choice = (Convert.ToInt32(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        Console.WriteLine("end of program");

        Console.ReadLine();

    }
}