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
      string outputString = testAnagram.RandomizeString();
      //Act
      string otherInputField = "llHeo";
      Anagram testAnagram2 = new Anagram(otherInputField);
      string verifyString = testAnagram2.RandomizeString();

      //Assert
        Assert.Equal(Anagram.Check(verifyString, outputString), true);
    }
  }
}
