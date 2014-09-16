using System;
using System.Collections.Generic;

namespace Chapter01.Models
{
    /// <summary>
    /// This is the model we are binding to our view
    /// </summary>
    public class GuitarCaseModel
    {
        public List<GuitarPick> Picks { get; set; }
        public List<GuitarCable> Cables { get; set; }
        public Guitar MyGuitar { get; set; }
    }


    // the following three classes are local to this file 
    // but could of also been defined in another assembly
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