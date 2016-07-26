using Xunit;
using System;

namespace WordRepeat
{
  public class RepeatTest
  {
    [Fact]
    public void CountRepeats_IsSingleLetterRepeat_true()
    {
      Repeat testRepeat = new Repeat("a", "a");
      Assert.Equal(true, testRepeat.CountRepeats());
    }

    [Fact]
    public void CountRepeats_IsSingleLetterRepeat_false()
    {
      Repeat testRepeat = new Repeat("a", "b");
      Assert.Equal(false, testRepeat.CountRepeats());
    }





  }
}
