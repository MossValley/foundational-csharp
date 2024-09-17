/*
  This code reverses a string and counts the number
  of times a particular character appears.
*/
using Microsoft.VisualBasic;

string input = "The quick brown fox jumps over the lazy dog.";

char[] message = input.ToCharArray();
Array.Reverse(message);

int count = 0;
foreach (char letter in message)
{ 
  if (letter == 'o')
  { 
    count++; 
  } 
}

string newMessage = new String(message);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");