// This file was auto-generated based on version 1.1.0 of the canonical data.

using Xunit;

public class ScrabbleScoreTest
{
    [Fact]
    public void Lowercase_letter()
    {
        Assert.Equal(1, ScrabbleScore.Score("a"));
    }

    [Fact]
    public void Uppercase_letter()
    {
        Assert.Equal(1, ScrabbleScore.Score("A"));
    }

    [Fact]
    public void Valuable_letter()
    {
        Assert.Equal(4, ScrabbleScore.Score("f"));
    }

    [Fact]
    public void Short_word()
    {
        Assert.Equal(2, ScrabbleScore.Score("at"));
    }

    [Fact]
    public void Short_valuable_word()
    {
        Assert.Equal(12, ScrabbleScore.Score("zoo"));
    }

    [Fact]
    public void Medium_word()
    {
        Assert.Equal(6, ScrabbleScore.Score("street"));
    }

    [Fact]
    public void Medium_valuable_word()
    {
        Assert.Equal(22, ScrabbleScore.Score("quirky"));
    }

    [Fact]
    public void Long_mixed_case_word()
    {
        Assert.Equal(41, ScrabbleScore.Score("OxyphenButazone"));
    }

    [Fact]
    public void English_like_word()
    {
        Assert.Equal(8, ScrabbleScore.Score("pinata"));
    }

    [Fact]
    public void Empty_input()
    {
        Assert.Equal(0, ScrabbleScore.Score(""));
    }

    [Fact]
    public void Entire_alphabet_available()
    {
        Assert.Equal(87, ScrabbleScore.Score("abcdefghijklmnopqrstuvwxyz"));
    }

    // special case tests
    [Fact]
    public void Double_letter()
    {
        Assert.Equal(9, ScrabbleScore.SpecialLetterScore(ScrabbleScore.Score("pinata"), "double", 'n'));
    }
    
    [Fact]
    public void Triple_letter()
    {
        Assert.Equal(10, ScrabbleScore.SpecialLetterScore(ScrabbleScore.Score("pinata"), "Triple", 'n'));
    }

    [Fact]
    public void Double_word()
    {
        Assert.Equal(16, ScrabbleScore.SpecialWordScore(ScrabbleScore.Score("pinata"), "Double"));
    }

    [Fact]
    public void Triple_word()
    {
        Assert.Equal(24, ScrabbleScore.SpecialWordScore(ScrabbleScore.Score("pinata"), "triple"));
    }

    [Fact]
    public void Special_word_and_letter()
    {
        Assert.Equal(27, ScrabbleScore.SpecialWordScore(ScrabbleScore.SpecialLetterScore(ScrabbleScore.Score("pinata"), "double", 'n'), "triple"));
    }

    [Fact]
    public void Random_character()
    {
        Assert.Equal(0, ScrabbleScore.Score("["));
    }

    [Fact]
    public void Invalid_special_word_type()
    {
        Assert.Equal(8, ScrabbleScore.SpecialWordScore(ScrabbleScore.Score("pinata"), "Doubleword"));
    }

    [Fact]
    public void Random_character_in_word()
    {
        Assert.Equal(41, ScrabbleScore.Score("Oxyphen-Butazone"));
    }
}