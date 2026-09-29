CalculatorApp();



void CalculatorApp()
{
    //ask for first number
    Console.WriteLine("Type the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    //ask for second number
    Console.WriteLine("Type the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    //ask for operation
    Console.WriteLine("Choose an option from the following list: ");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Divide");

    //convert string to int
    int choice = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 3)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 4)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
    }
    else
    {
        Console.WriteLine("Invalid choice - Please select option 1-4");
    }


    //other option using switch statement

    /*
    //perform calculation
    int result = 0;
    switch (choice)
    {
        case 1:
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
            break;
        case 2:
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
            break;
        case 3:
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
            break;
        case 4:
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
            break;
    }
    */

}