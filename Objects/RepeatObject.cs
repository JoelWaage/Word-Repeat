using System.Collections.Generic;
using System;

namespace WordRepeat
{
  public class Repeat
  {
    private string _word;
    private string _sentence;
    private int _repeatCount;

    public Repeat(string inputWord, string inputSentence)
    {
      _word = inputWord;
      _sentence = inputSentence;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public int GetCount()
    {
      return _repeatCount;
    }


    public int CountRepeats()
    {
      string[] sentence;
      sentence = this.GetSentence().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
      sentence = this.GetSentence().Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
      sentence = this.GetSentence().Split(null as string[], StringSplitOptions.RemoveEmptyEntries);


      foreach(var piece in sentence)
      {
        if (this.GetWord() == this.GetSentence())
        {
          _repeatCount++;
        }
      }
      return _repeatCount;
    }
  }
}
