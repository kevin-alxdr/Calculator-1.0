namespace Calculator
{
     
    class Calculator
    {
        static void Main(string[] args)
        {
            Menuu();
        }

        static void Menuu()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("===================");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit\n");

            Console.WriteLine("Please select a operation (1-5): ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Addition.Add();

                    Console.WriteLine("Would you like to add again? (y/n)");
                    string again = Console.ReadLine();
                    while (again == "y")
                    {
                        Addition.Add();
                        Console.WriteLine("Would you like to add again? (y/n)");
                        again = Console.ReadLine();
                    }

                    if (again == "n")
                    {
                        Console.WriteLine("Returning to main menu...\n");
                        Menuu();
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid option. (y/n)");
                        Menuu();
                    }

                    break;


                case 2:
                    Subtraction.Subtract();

                    Console.WriteLine("Would you like to subtract again? (y/n)");
                    string again2 = Console.ReadLine();
                    while (again2 == "y")
                    {
                        Subtraction.Subtract();
                        Console.WriteLine("Would you like to subtract again? (y/n)");
                        again2 = Console.ReadLine();
                    }


                    if (again2 == "n")
                    {
                        Console.WriteLine("Returning to main menu...\n");
                        Menuu();
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid option. (y/n)");
                        Menuu();
                    }
                    break;


                case 3:
                    Multiplication.Multiply();

                    Console.WriteLine("Would you like to mulitply again? (y/n)");
                    string again3 = Console.ReadLine();
                    while (again3 == "y")
                    {
                        Subtraction.Subtract();
                        Console.WriteLine("Would you like to multiply again? (y/n)");
                        again3 = Console.ReadLine();
                    }


                    if (again3 == "n")
                    {
                        Console.WriteLine("Returning to main menu...\n");
                        Menuu();
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid option. (y/n)");
                        Menuu();
                    }
                    break;


                case 4:
                    Divition.Divide();

                    Console.WriteLine("Would you like to divide again? (y/n)");
                    string again4 = Console.ReadLine();
                    while (again4 == "y")
                    {
                        Divition.Divide();
                        Console.WriteLine("Would you like to divide again? (y/n)");
                        again4 = Console.ReadLine();
                    }

                    if (again4 == "n")
                    {
                        Console.WriteLine("Returning to main menu...\n");
                        Menuu();
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid option. (y/n)");
                        Menuu();
                    }
                    break;


                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
