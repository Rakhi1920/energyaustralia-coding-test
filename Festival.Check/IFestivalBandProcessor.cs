using System;
using Festival.Models;

namespace Festival.Check
{
    interface IFestivalBandProcessor
    {
        void CheckFestival(MusicFestival musicFestival);
        void CheckBand(Band band);
    }
}
