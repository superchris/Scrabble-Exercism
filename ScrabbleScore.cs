using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    static Dictionary<char, int> values = new Dictionary<int, string>()

        {
            {1, "aeioulnrst"},
            {2, "dg"},
            {3, "bcmp"},
            {4, "fhvwy"},
            {5, "k"},
            {8, "jx"},
            {10, "qz"}
      }.SelectMany(kv => kv.Value.Select(c => (c, kv.Key)))
      .ToDictionary(kv => kv.c, kv => kv.Key);

    private static int letterValues(char letter)
    {
      return values.GetValueOrDefault(letter);
        // int value = values.FirstOrDefault(x => x.Value.Contains(letter)).Key;

        // return value;
    }
    public static int Score(string input)
    {
        int score = 0;
        string word = input.ToLower();

        var scores = word.Select(c => letterValues(c));

        score = scores.Sum();

        return score;
    }
    public static int SpecialLetterScore(int score, string type, char letter)
    {
        type = type.ToLower();

        int finalScore = type == "double" ? score + letterValues(letter) : type == "triple" ? score + (2 * letterValues(letter)): score;

        return finalScore;

    }
    public static int SpecialWordScore(int score, string type)
    {
        type = type.ToLower();

        int finalScore = type == "double" ? score * 2 : type == "triple" ? score * 3 : score;

        return finalScore;
    }
}
