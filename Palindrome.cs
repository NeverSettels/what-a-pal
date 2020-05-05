using System;
using System.Collections.Generic;

public class Palindrome
{
  public static bool IsAPal(string input)
  {
    bool IsPal = false;
    List<char> letters = new List<char> { };
    foreach (char letter in input)
    {
      letters.Add(letter);
    }
    for (int i = 0; i < letters.Count; i++)
    {
      int OppositeIndex = letters.Count - 1 - i;
      if (letters[i] == letters[OppositeIndex])
      {
        IsPal = true;
      }
      else
      {
        IsPal = false;
        break;
      }
    }
    return IsPal;
  }
  public static void Main()
  {
    Console.Write("Enter a word to see if its a Palindrome: ");
    string input = (Console.ReadLine().ToLower());
    Console.WriteLine(IsAPal(input));
  }
}