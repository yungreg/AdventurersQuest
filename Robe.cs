using System;
using System.Collections.Generic;

namespace Quest
{
    public class Robe
    {
        public string RobeColor { get; set; }
        public int RobeLength { get; set; }


        public Robe(string robeColor, int robeLength)
        {
            robeColor = RobeColor;
            robeLength = RobeLength;
        }

    }
}