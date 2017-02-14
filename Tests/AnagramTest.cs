using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void Randomize_ToRandomizeTheLettersIntoAnotherWord_String()
    {
      //Arrange
      string input = "Hello";
      Anagram testAnagram = new Anagram(input);
      List<string> outputList = testAnagram.Randomize();
      //Act
      List<string> verifyList = new List<string>{ "H","e","l","l","o" };

      //Assert
      Assert.Equal(outputList, verifyList);
    }
    [Fact]
    public void RandomizeWords_ToRandomizeTheLettersIntoAnotherWord_String()
    {
      //Arrange
      string input = "Hello";
      Anagram testAnagram = new Anagram(input);
      string outputString = testAnagram.RandomizeString();
      //Act
      string verifyString = "eHllo";

      //Assert
      Assert.Equal(outputString, verifyString);
    }
    [Fact]
    public void CheckWords_userInput_false()
    {
      //Arrange
      string input = "Hello";
      Anagram testAnagram = new Anagram(input);
      string outputString = testAnagram.RandomizeString();
      //Act
      string verifyString = "Hello";

      //Assert
      Assert.Equal(testAnagram.Check(verifyString), false);
    }
  }
}
