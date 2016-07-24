using Xunit;
using System;

namespace WordRepeat.Objects
{
  public class RepeatTest
  {
    [Fact]
    public void CountRepeats.IsSingleLetterRepeat_true()
    {
      Repeat testRepeat = new Repeat("a", "a");
      Assert.Equal(true, testRepeat.CountRepeats());
    }






  }
}
