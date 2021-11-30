public static class Calculator{

    public static void Main(string[] args){

        int input = 0;

        while (input != 6)
        {
            Console.WriteLine("What do you want to calculate? Enter a number: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Find a Square Root");
            Console.WriteLine("6. Quit" + "\n");
            input = Convert.ToInt32(Console.ReadLine() + "\n");

        switch (input)
        {
            case 1: 
                Console.WriteLine("Enter the first number to add:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number to add:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " plus " + num2 + " is equal to " + (num1 + num2) + "\n");
                break;
            
            case 2:
                Console.WriteLine("Enter the first number to subtract:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number to subtract:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " minus " + num2 + " is equal to " + (num1 - num2) + "\n");
                break;

            case 3: 
                Console.WriteLine("Enter the first number to multiply:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number to multiply:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " multiplied by " + num2 + " is equal to " + (num1 * num2) + "\n");
                break;   

            case 4:
                Console.WriteLine("Enter the first number to divide:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number to divide:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 + " divided by " + num2 + " is equal to " + (num1 / num2) + "\n");
                
                break;

            case 5:
                Console.WriteLine("Enter your number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The square root of " + num1 + " is " + Math.Sqrt(num1) + "\n");
                
                break;

            case 6:    
                Console.WriteLine("Thank you for calculating.");
                break;

            default: 
                Console.WriteLine("That selection is invalid." + "\n");
                break;
    }
} 
    }
}