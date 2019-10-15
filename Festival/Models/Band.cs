using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class Band
    {
        [Key]
        public int bandId { get; set; }

        public int? festivalId { get; set; }
        public string name { get; set; }
        public string recordLabel { get; set; }

        [ForeignKey("festivalId")]
        public virtual MusicFestival MusicFestival { get; set; }
    }
}
