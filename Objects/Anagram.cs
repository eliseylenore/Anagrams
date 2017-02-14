using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams.Objects
{
  public class Anagram
  {
    private string _input;
    public string _output = "";
    public string _reverseOutput ="";
    public List<char> _inputList = new List<char>{};

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

    public string RandomizeString()
    {
      char[] inputArray = _input.ToCharArray();
      foreach (char letter in inputArray)
      {
        _inputList.Add(letter);
      };
      var result = _inputList.Select(c => c.ToString()).ToList();
      result.Sort();
      _output = string.Join( "", result.ToArray() );
      return _output;
    }

    public static bool Check(string userString, string _output)
    {
      if (userString == _output)
      {return true;}
      else
      {return false;}
    }
  }
}
