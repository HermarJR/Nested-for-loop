internal class Program
{
    private static void Main(string[] args)
    {
       bool TryAgain = true;
       
        while (TryAgain)
        {

            Console.Write("How many rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.Write("Would you like to continue? (Y/N) ");
            string again = Console.ReadLine();
            again = again.ToUpper();

            if (again == "N")
            {
                TryAgain = false;
                Console.WriteLine("Thank you for playing!");
            }

        }


        Console.ReadKey();

    }
}