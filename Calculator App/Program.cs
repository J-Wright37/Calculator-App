CalculatorApp();



void CalculatorApp()
{

    try {
        //prompt user to enter first number
        Console.WriteLine("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        //prompt user to enter second number
        Console.WriteLine("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        //prompt user to enter operation
        Console.WriteLine("Enter operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        //perform operation
        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }
        //output result
        Console.WriteLine($"Result: {result}");

    }
    catch (FormatException ex) {
        //handle case where input not valid
        Console.WriteLine($"Error: {ex.Message} Please enter valid operation");

    } catch (DivideByZeroException ex) {
        //handles divide by zero error
        Console.WriteLine($"You cannot divide by zero.");

    } finally {
        Console.WriteLine("Operation Completed.");

    }



}