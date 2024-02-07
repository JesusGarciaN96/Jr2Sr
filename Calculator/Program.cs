namespace Calculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            showMenu();
        }

        public static void showMenu()
        {
            try
            {
                Console.WriteLine("Calculator C#");
                Console.WriteLine("Input first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("[A]DD");
                Console.WriteLine("[S]UBSTRACT");
                Console.WriteLine("[M]ULTIPLY");
                Console.WriteLine("Input option: ");
                char option = Convert.ToChar(Console.ReadLine().ToUpper()[0]);

                operatorCalculator(firstNumber, secondNumber, option);
            }
            catch
            {
                Console.WriteLine("Some error is ocurred!");
            }
        }

        public static void operatorCalculator(int firstNumber, int secondNumber, char option)
        {
            if (option == 'A')
            {
                Console.WriteLine("Result: " + (firstNumber + secondNumber));
            }
            else if (option == 'S')
            {
                Console.WriteLine("Result: " + (firstNumber - secondNumber));
            }
            else if (option == 'M')
            {
                Console.WriteLine("Result: " + (firstNumber * secondNumber));
            }
            else
            {
                Console.WriteLine("Invalid option, press any key to exit.");
            }
        }
    }
}