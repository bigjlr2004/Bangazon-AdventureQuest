using System;
using System.Collections.Generic;

namespace Quest
{
    // The class should have the following mutable properties.
    // Colors - a list of strings to hold the colors of the robe
    // Length - an integer describing the length of the robe in inches
    // The class should not contain any methods or constructors.
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription()
        {
            string HatStatus = "boring";
            if (ShininessLevel < 2)
            {
                HatStatus = "dull";
            }
            else if (ShininessLevel >= 2 && ShininessLevel <= 5)
            {
                HatStatus = "noticeable";
            }
            else if (ShininessLevel >= 6 && ShininessLevel <= 9)
            {
                HatStatus = "bright";
            }
            else if (ShininessLevel > 9)
            {
                HatStatus = "blinding";
            }

            return HatStatus;
        }
    }
}