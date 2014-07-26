using System;
using System.Collections.Generic;

namespace Chapter1R4.Models
{
    /// <summary>
    /// Summary description for WhatsInMyGuitarCaseModel
    /// </summary>
    public class GuitarCaseModel
    {
        public List<GuitarPick> Picks { get; set; }
        public List<GuitarCable> Cables { get; set; }
        public Guitar MyGuitar { get; set; }
    }

    public class Guitar
    {
        public string Brand { get; set; }
        public string BodyStyle { get; set; }
        public string Finish { get; set; }
    }

    public class GuitarCable
    {
        public string Brand { get; set; }
        public int  Gage { get; set; }
    }
    public class GuitarPick
    {
        public string Brand { get; set; }
        public string Thickness { get; set; }
    }

}