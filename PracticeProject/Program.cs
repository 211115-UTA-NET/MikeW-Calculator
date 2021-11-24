public static class Calculator{

public static void Main(string[] args){

    
int input = 0;

while (input != 5)
{ 
    Console.WriteLine("What do you want to calculate? Enter a number.");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Quit");
    
    input = Convert.ToInt32(Console.ReadLine());

    

// if (input == 1)
// {
//     Console.WriteLine("Enter your first number");
//     double num1;
//     num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter your second number");
//     double num2;
//     num2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine(num1 + " plus " + num2 + " is equal to " + (num1 + num2));
// } 

//     else if (input == 2)
// {
//     Console.WriteLine("Enter your first number");
//     double num1;
//     num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter your second number");
//     double num2;
//     num2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine( num1 + " minus " + num2 + " equals " + (num1 - num2));
// }

//     else if (input == 3)
//     {
//         Console.WriteLine("Enter your first number");
//     double num1;
//     num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter your second number");
//     double num2;
//     num2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine(num1 + " multiplied by " + num2 + " is equal to " +(num1 * num2));
//     }
   
//     else if (input == 4)
//     {
//         Console.WriteLine("Enter your first number");
//     double num1;
//     num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter your second number");
//     double num2;
//     num2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine(num1 + " divided by " + num2 + " is equal to " + (num1 / num2));
//     }
//    }
// Console.WriteLine("Thanks for Calculating.");

}
    
}