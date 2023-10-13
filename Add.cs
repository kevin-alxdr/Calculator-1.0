namespace Calculator
{
    class Addition
    {
        public static void Add()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("           ADD            ");
            Console.WriteLine("--------------------------");

            Console.WriteLine("\nEnter number 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter number 2: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int answer = (input1 + input2);
            Convert.ToString(answer);

            Console.WriteLine("\nAnswer: " + answer);

        }
    }
}
