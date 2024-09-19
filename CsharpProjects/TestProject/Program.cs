//FizzBuzz challenge

for (int i = 1; i <= 100; i++)
{
    string print = "";

    if (i % 3 == 0)
        print = "Fizz";

    if (i % 5 == 0)
        print = $"{print}Buzz";

    Console.WriteLine($"{i}{(print.Length > 0 ? $"- {print}" : "")}");
}