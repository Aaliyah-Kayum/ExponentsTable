class Program
{
    public static void Main()
    {

        Console.WriteLine("Learn your squares and cubes!");

        int integer = 0;
        do
        {
            int squared = integer;
            int cubed = integer;

            Console.WriteLine("Please enter an integer: ");
            Console.WriteLine("It cannot be a negative number or 0");
            integer = int.Parse(Console.ReadLine());

            if (integer <= 0)
            {
                Console.WriteLine("Invalid Input");
                break;

            }
            
            {
                squared = integer * integer;
                cubed = integer * integer * integer;

                Console.WriteLine("Number  Squared  Cubed");
                Console.WriteLine("======  =======  ======");
            }

            for (int i = 1; i <= integer; i++)
            {
                Console.WriteLine("  {0}        {1}      {2}  ", integer, square(integer), cube(integer));
            }
            //method to count up
            static int square(int num)
            {
                return num * num;
            }
            static int cube(int num)
            {
                return num * num * num;
            }
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    continue;
                }
                else if (answer.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.");
                    //cue breakdown lol
                    continue;
                }
            }
        }
        while (true);
    }
}