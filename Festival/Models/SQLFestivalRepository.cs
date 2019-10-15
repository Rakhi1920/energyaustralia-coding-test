using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class SQLFestivalRepository : IMusicFestivalRepository
    {
        private readonly AppDbContext context;

        public SQLFestivalRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<BandFestivalDto> GetMusicFestivals()
        {
            return (from e in context.MusicFestival
                    join Band in context.Band
                    on e.festivalId equals Band.festivalId into MusicFestivalBand
                    from mfb in MusicFestivalBand.DefaultIfEmpty()

                    select new BandFestivalDto
                    {
                        recordLabel = mfb.recordLabel,
                        bandName = mfb.name,
                        festivalName = e.name
                    }
                      ).ToArray();
        }
    }
}
