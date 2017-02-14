using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams.Objects
{
  public class AnagramTest
  {
    // [Fact]
    // public void RandomizeWords_userInputandOurInput_true()
    // {
    //   //Arrange
    //   string input = "Path";
    //   Anagram testAnagram = new Anagram(input);
    //   string outputString = testAnagram.SortString();
    //
    //   List<string> expectedOutput = new List<string>{"ahPt"};
    //
    //   //Act
    //   string otherInputField = "Hello my name is Elise olleH lloHe ole ello llo ahPt hpt hat";
    //   List<string> outputList = testAnagram.SortSentence(otherInputField, outputString);
    //   foreach (string whatever in outputList)
    //   {Console.WriteLine(whatever);};
    //   //Assert
    //   Assert.Equal(expectedOutput, outputList);
    // }

    [Fact]
    public void RandomizeWords_userInputandOurInput_true()
    {
      //Arrange
      string input = "Hello";
      Anagram testAnagram = new Anagram(input);
      List<string> outputList = testAnagram.SortString();

      List<string> expectedOutput = new List<string>{"ahPt"};

      //Act
      string otherInputField = "Helo my name is Elise olleH lloHe ole ello llo ahPt hpt hat";
      List<string> result = testAnagram.SortSentence(otherInputField, outputList);
      foreach (string whatever in result)
      {Console.WriteLine(whatever);};
      //Assert
      Assert.Equal(expectedOutput, result);
    }
  }
}
