using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void RandomizeWords_userInputandOurInput_true()
    {
      //Arrange
      string input = "Hello";
      Anagram testAnagram = new Anagram(input);
      string outputString = testAnagram.SortString();

      List<string> expectedOutput = new List<string>{"Hello"};

      //Act
      string otherInputField = "Hello my name is Elise olleH lloHe";
      List<string> outputList = testAnagram.SortSentence(otherInputField, outputString);
      foreach (string whatever in outputList)
      {Console.WriteLine(whatever);};
      //Assert
      Assert.Equal(expectedOutput, outputList);
    }
  }
}
