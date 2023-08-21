using System;
using System.Collections.Generic;

namespace Quest
{

    public class Prize
    {
        private string Description { get; set; }

        public Prize(string description)
        {
            Description = description;
        }


        public void ShowPrize(Adventurer adventurer)
        {

            if (adventurer.Awesomeness <= 0)
            {
                Console.WriteLine("You are not very awesome, You should try again.");
            }
            else if (adventurer.Awesomeness > 0)
            {
                for (int i = adventurer.Awesomeness; i > 0; i--)
                {
                    Console.WriteLine(Description);
                }
            }

        }
    }
}