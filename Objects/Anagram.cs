using System;
using System.Collections.Generic;

namespace Anagrams.Objects
{
  public class Anagram
  {
    private string _input;
    public string _output;
    public char[] _inputArray = new char[]{};

    public Anagram (string newInput)
    {
      _input = newInput;
    }

    public string GetInput()
    {
      return _input;
    }
    public void SetInput( string MyInput)
    {
      _input = MyInput;
    }

    public char[] SplitArray()
    {
      _inputArray = _input.ToCharArray();
      return _inputArray;
    }

    // public string Randomize()
    // {
    //
    // }
  }
}
