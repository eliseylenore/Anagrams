using Xunit;
using System;
using System.Collections.Generic;

namespace Anagrams.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void SplitArray_InputWords_ArrayOfSplittedChar()
    {
      //Arrange
      string input = "Hello";
      Anagram testAnagram = new Anagram(input);
      char[] inputArray = testAnagram.SplitArray();
      //Act
      char[] verifyArray = new char[]{ 'H', 'e', 'l', 'l', 'o' };
      //Assert
      Assert.Equal(inputArray,verifyArray);
    }
  }
}
