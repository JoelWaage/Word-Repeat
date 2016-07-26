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






  }
}
