using System.Collections.Generic;
using System;

namespace WordRepeat
{
  public class Repeat
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
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }


    public bool CountRepeats()
    {
      string[] sentence;

      sentence = this.GetSentence().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

      sentence = this.GetSentence().Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);

      sentence = this.GetSentence().Split(null as string[], StringSplitOptions.RemoveEmptyEntries);

      Console.WriteLine(sentence[0]);

      if (this.GetWord() == this.GetSentence())
      {
        return true;
      }
      else
      {
        return false;
      }

    }
  }
}
