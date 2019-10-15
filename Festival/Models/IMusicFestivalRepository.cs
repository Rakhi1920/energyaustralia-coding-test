using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
   public interface IMusicFestivalRepository
    {
        IEnumerable<BandFestivalDto> GetMusicFestivals();
    }
}
