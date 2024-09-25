/* string? userInput;
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

Console.WriteLine($"Your input value ({numberValue}) has been accepted");*/

/* string? userInput;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string[] acceptableRoles = new string[] { "administrator", "manager", "user" };

do
{
    string input = Console.ReadLine();
    userInput = input == null ? input : input.Trim().ToLower();

    if (!acceptableRoles.Contains(userInput))
        Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");

} while (!acceptableRoles.Contains(userInput));

Console.WriteLine($"Your input value ({userInput}) has been accepted."); */

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];

    int periodLocation = myString.IndexOf('.');

    do
    {
        if (periodLocation == -1) {
            Console.WriteLine(myString.TrimStart());
            break;
        }
        else {
            string output = myString.Remove(periodLocation);
            Console.WriteLine(output.TrimStart());
            myString = myString.Substring(periodLocation + 1, myString.Length - periodLocation -1 );
            periodLocation = myString.IndexOf('.');
        }
    } while (myString.Length > 0);
}
