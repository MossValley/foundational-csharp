string? userInput;
Console.WriteLine("Enter an integer value between 5 and 10");

int numberValue = 0;
bool isNumber = false;
bool isValidNumber = false;

do
{
    userInput = Console.ReadLine();
    isNumber = int.TryParse(userInput, out numberValue);

    if (isNumber)
    {
        if (numberValue < 5 || numberValue > 10)
            Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10");
        else
            isValidNumber = true;
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }


} while (!isValidNumber);

Console.WriteLine($"Your input value ({numberValue}) has been accepted");