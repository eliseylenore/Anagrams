using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams.Objects
{
  public class Anagram
  {
    private string _input;
    public string _output = "";
    public string _userPhrase ="";
    public List<char> _inputList = new List<char>{};
    public List<string> _outputList = new List<string>{};

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

    public List<string> SortString()
    {
      char[] inputArray = _input.ToCharArray();
      foreach (char letter in inputArray)
      {
        _inputList.Add(letter);
      };
      var result = _inputList.Select(c => c.ToString()).ToList();
      return result;
    }


    public List<string> SortSentence(string sentence, List<string> myList) {
      string[] splitSentence = sentence.Split(' ');
      foreach (string word in splitSentence)
      {
        Anagram phrases = new Anagram(word);
        List<string> result = phrases.SortString();
        if (result.Intersect(myList).Count() == result.Count())
        // result.Intersect(myList).Count() == result.Count()
        {
          _outputList.Add(word);
        }
      }
      return _outputList;
    }


    // public string SortString()
    // {
    //   char[] inputArray = _input.ToCharArray();
    //   foreach (char letter in inputArray)
    //   {
    //     _inputList.Add(letter);
    //   };
    //   var result = _inputList.Select(c => c.ToString()).ToList();
    //   result.Sort();
    //   _output = string.Join( "", result.ToArray() );
    //   return _output;
    // }
    //
    // public List<string> SortSentence(string sentence, string _output) {
    //   string[] splitSentence = sentence.Split(' ');
    //   foreach (string word in splitSentence)
    //   {
    //     Anagram phrases = new Anagram(word);
    //     _userPhrase = phrases.SortString();
    //     if (_output.Contains(_userPhrase))
    //     {
    //       _outputList.Add(word);
    //     }
    //   }
    //   return _outputList;
    // }
  }
}
