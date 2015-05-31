using System;
using System.ComponentModel.DataAnnotations;

namespace Recipe04.Web.Models
{
    public class OpenPositionsNeeded
    {
        [Display(Name = "Bass Guitar")]
        public bool BassGuitar { get; set; }

        public bool Drums { get; set; }

        public bool Guitar { get; set; }

        public bool Keyboards { get; set; }

        public bool Vocals { get; set; }

        public bool Lyricist { get; set; }

        public bool Producer { get; set; }

        public bool Songwriter { get; set; }
    }
}