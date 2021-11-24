public static class Calculator{

    public static void Main(string[] args){

        int input = 0;
        while (input != 5)
        {
            Console.WriteLine("What do you want to calculate? Enter a number: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Quit");
            
            input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1: 
                Console.WriteLine("enter the first number to add");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the secod number to add");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " plus " + num2 + " is equal to " + (num1 + num2));
                break;
            
            case 2:
                Console.WriteLine("enter the first number to subtract");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the secod number to subtract");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " minus " + num2 + " is equal to " + (num1 - num2));
                break;

            case 3: 
                Console.WriteLine("enter the first number to multiply");
                double num5 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the secod number to multiply");
                double num6 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num5 + " multiplied by " + num6 + " is equal to " + (num5 * num6));
                break;   

            case 4:
                Console.WriteLine("enter the first number to divide");
                double num7 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the secod number to divide");
                double num8 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num7 + " divided by " + num8 + " is equal to " + (num7 / num8));
                break;

            case 5:
                Console.WriteLine("Thanks for calculating.");
                break;
        }
        } 
    }
} 