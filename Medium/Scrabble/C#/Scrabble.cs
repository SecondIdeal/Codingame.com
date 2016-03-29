using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        Dictionary<char, int> allLettersAndValues = new Dictionary<char, int>()
        {
	        {'e', 1}, {'a', 1}, {'i', 1}, {'o', 1}, {'n', 1}, {'r', 1}, {'t', 1}, {'l', 1}, {'s', 1}, {'u', 1},
	        {'d', 2}, {'g', 2},
            {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3},
            {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4},
	        {'k', 5},
	        {'j', 8}, {'x', 8},
            {'q', 10}, {'z', 10}
	    };

        int numberOfWords = int.Parse(Console.ReadLine());

        Dictionary<string, int> givenWords = new Dictionary<string, int>();
        for (int i = 0; i < numberOfWords; i++)
            givenWords.Add(Console.ReadLine(), 0);

        char[] availableLetters = Console.ReadLine().ToCharArray();

        List<char> availableLettersFroCurrentWord = new List<char>(availableLetters.Length);

        int maxValue        = 0;
        string maxValueWord = "";

        List<string> listOfWords = new List<string>(givenWords.Keys);
        foreach (string word in listOfWords)
        {
            if (word.Length <= availableLetters.Length)
            {
                availableLettersFroCurrentWord = availableLetters.ToList();
                foreach (char letter in word)
                {
                    if (availableLettersFroCurrentWord.Contains(letter))
                    {
                        givenWords[word] = givenWords[word] + allLettersAndValues[letter];
                        availableLettersFroCurrentWord.Remove(letter);
                    }
                    else
                        givenWords[word] = -99; // For cases when word consist of restricted letters
                }
                if (maxValue < givenWords[word])
                {
                    maxValue = givenWords[word];
                    maxValueWord = word;
                }
            }
        }
        Console.WriteLine(maxValueWord);
    }
}