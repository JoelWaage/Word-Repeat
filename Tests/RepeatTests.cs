using Xunit;
using System;

namespace WordRepeat
{
  public class RepeatTest
  {
    [Fact]
    public void CountRepeats_IsSingleLetterRepeat_1()
    {
      Repeat testRepeat = new Repeat("a", "a");
      Assert.Equal(1, testRepeat.CountRepeats());
    }
    [Fact]
    public void CountRepeats_IsSingleLetterNotRepeat_0()
    {
      Repeat testRepeat = new Repeat("a", "b");
      Assert.Equal(0, testRepeat.CountRepeats());
    }

    [Fact]
    public void CountRepeats_IsStringRepeat_1()
    {
      Repeat testRepeat = new Repeat("ab", "ab");
      Assert.Equal(1, testRepeat.CountRepeats());
    }
    [Fact]
    public void CountRepeats_IsStringNotRepeat_0()
    {
      Repeat testRepeat = new Repeat("ab", "cd");
      Assert.Equal(0, testRepeat.CountRepeats());
    }

    [Fact]
    public void CountRepeats_IsOnOfSeveralLettersSame_1()
    {
      Repeat testRepeat = new Repeat("a", "a b c");
      Assert.Equal(1, testRepeat.CountRepeats());
    }
    [Fact]
    public void CountRepeats_IsOneOfSeveralLettersNotSame_0()
    {
      Repeat testRepeat = new Repeat("a", "b c d");
      Assert.Equal(0, testRepeat.CountRepeats());
    }





  }
}
