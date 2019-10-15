using Festival.Check;
using System;
using Xunit;

namespace Festival.UnitTest
{
    public class FestivalBandProcessorUnitTest
    {
        [Fact]
        public void Test_InValid_MusicFestivalId()
        {
            var festivalBandProcessor = new FestivalBandProcessor();
            Assert.Throws<ArgumentOutOfRangeException>(() => festivalBandProcessor.CheckFestival(new  Models.MusicFestival()));

        }

        [Fact]
        public void Test_InValid_BandId()
        {
            var festivalBandProcessor = new FestivalBandProcessor();
            Assert.Throws<ArgumentOutOfRangeException>(() => festivalBandProcessor.CheckBand(new Models.Band()));

        }

    }
}
