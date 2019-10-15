using System;
using System.Collections.Generic;
using System.Text;
using Festival.Models;

namespace Festival.Check
{
    public class FestivalBandProcessor : IFestivalBandProcessor
    {
        public void CheckBand(Band band)
        {
            if(band.bandId <=0 )
            {
             throw new ArgumentOutOfRangeException(" Band Id cannot be less than 0");
            }

        }

        public void CheckFestival(MusicFestival musicFestival)
        {
            if(musicFestival.festivalId <=0 )
            {
                throw new ArgumentOutOfRangeException("Festival Id cannot be less than 0");
            }

            
        }
    }
}
