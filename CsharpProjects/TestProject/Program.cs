string? userInput;
Console.WriteLine("Enter an integer value between 5 and 10");

int numberValue = 0;
bool isNumber;

while (numberValue < 5 || numberValue > 10)
{
    userInput = Console.ReadLine();
    isNumber = int.TryParse(userInput, out numberValue);

    if (isNumber)
    {
        if (numberValue < 5 || numberValue > 10)
            Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10");
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
}

Console.WriteLine($"Your input value ({numberValue}) has been accepted");