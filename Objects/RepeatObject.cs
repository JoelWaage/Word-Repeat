using System.Collections.Generic;
using System;

namespace WordRepeat
{
  public class Repeat
  {
// Set Variables
    private string _word;
    private string _sentence;
    private int _repeatCount;

// Constructor
    public Repeat(string inputWord, string inputSentence)
    {
      _word = inputWord;
      _sentence = inputSentence;
    }

// Getters and Setters
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

// Methods
    public int CountRepeats()
    {
      string[] sentence;
      sentence = this.GetSentence().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
      sentence = this.GetSentence().Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
      sentence = this.GetSentence().Split(null as string[], StringSplitOptions.RemoveEmptyEntries);


      foreach(var piece in sentence)
      {
        if (this.GetWord() == piece)
        {
          _repeatCount++;
        }
      }
      return _repeatCount;
    }
  }
}
