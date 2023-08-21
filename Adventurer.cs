using System;
using System.Collections.Generic;

namespace Quest
{
    public class Adventurer
    {
        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        // Add a new immutable property to the Adventurer class called ColorfulRobe. The type of this property should be Robe.
        public Robe ColorfulRobe { get; }

        // A constructor to make a new Adventurer object with a given name
        // Add a new constructor parameter to the Adventurer class to accept a Robe and to set the ColorfulRobe property.
        public Adventurer(string name, Robe robe)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = robe;
        }
        string dispString = "";
        private string DisplayColors(List<string> colors)
        {
            foreach (string color in colors)
            {
                dispString += $" {color},";
            }
            return dispString;
        }

        // Add a new method to the Adventurer class called GetDescription. This method should return a string that contains the adventurer's name and a description of their robe.
        public string GetDescription()
        {
            return $"{Name} has a {DisplayColors(ColorfulRobe.Colors)} robe that is {ColorfulRobe.Length} feet long.";
        }

        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }
    }
}