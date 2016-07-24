using System.Collections.Generic;
using System;

namespace WordRepeat.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

    public Repeat(string inputWord, string inputSentence)
    {
      _word = inputWord;
      _sentence = inputSentence;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWrod(string newWord)
    {
      _word = newWord;
    }

    public string GetSentence()
    {
      return _comparison;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }


    public bool CountRepeats()
    {
      return false;

    }





  }
}
