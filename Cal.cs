using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        double result;
        char operation;


        Console.WriteLine("Hello,welcome to the calculator program");

        Console.WriteLine("Enter your first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("number1  = "+num1);


        Console.WriteLine("Enter your second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("number2 = "+num2);

        Console.WriteLine("Enter operation: ");
        operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Addition: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Substraction: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Multiplication: {num1} * {num2} = {result}");
                break;
            case '/':
                if(num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Division: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid input");
                break;

        }

       

        Console.ReadLine();
    }
}
