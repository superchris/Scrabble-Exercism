using System;

public static class ScrabbleScore
{
    private static int letterValues(char letter)
    {
        int value = 0;

        char[] addOne = new Char[10]{'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
        char[] addTwo = new Char[2]{'d', 'g'};
        char[] addThree = new Char[4]{'b', 'c', 'm', 'p'};
        char[] addFour = new Char[5]{'f', 'h', 'v', 'w', 'y'};
        char[] addFive = new Char[1]{'k'};
        char[] addEight = new Char[2]{'j', 'x'};
        char[] addTen = new Char[2]{'q', 'z'};
        
        if (Array.Exists(addOne, checkLetter => checkLetter == letter)) 
        {
                value = 1;
        }
        else if (Array.Exists(addTwo, checkLetter => checkLetter == letter)) 
        {
                value = 2;
        }
        else if (Array.Exists(addThree, checkLetter => checkLetter == letter)) 
        {
                value = 3;
        }
        else if (Array.Exists(addFour, checkLetter => checkLetter == letter)) 
        {
                value = 4;
        } 
        else if (Array.Exists(addFive, checkLetter => checkLetter == letter)) 
        {
                value = 5;
        }
        else if (Array.Exists(addEight, checkLetter => checkLetter == letter)) 
        {
                value = 8;
        }
        else if (Array.Exists(addTen, checkLetter => checkLetter == letter)) 
        {
                value = 10;
        }

        return value;
    } 
    public static int Score(string input)
    {
        int score = 0;
        string word = input.ToLower();

        foreach (char c in word) 
        {
            score += letterValues(c);
        }

        return score;
    }
    public static int SpecialLetterScore(int score, string type, char letter) 
    {
        type = type.ToLower();
        int addScore = 0;

        if (type == "double") 
        {
            addScore = letterValues(letter);
        } 
        else if (type == "triple")
        {
            addScore = 2 * letterValues(letter);
        }
        
        return score += addScore;
    }
    public static int SpecialWordScore(int score, string type) 
    {
        type = type.ToLower();
        
        if (type == "double") 
        {
            score *= 2;
        } 
        else if (type == "triple") 
        {
            score *= 3;
        }

        return score;
    }
}