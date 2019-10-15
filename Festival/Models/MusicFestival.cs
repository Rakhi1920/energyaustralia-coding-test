using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class MusicFestival
    {
        public MusicFestival()
        {
            Bands = new HashSet<Band>();
        }

        [Key]
        public int festivalId { get; set; }
        public string name { get; set; }

        public ICollection<Band> Bands { get; set; }

    }
}
