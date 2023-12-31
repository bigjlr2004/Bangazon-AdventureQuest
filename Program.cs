﻿using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge

            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge howManyStates = new Challenge("How many states are there in the USA?", 50, 25);
            Challenge howManyContinents = new Challenge("How many continents are there?", 7, 35);
            Challenge noRoman = new Challenge("What number does not have a roman numeral?", 0, 25);
            Challenge popularNumber = new Challenge("What number is the most popular two-digit number?", 13, 25);
            Challenge luckiestNumber = new Challenge("What number is the luckies single digit number?", 7, 25);
            Challenge alphabetNumber = new Challenge("What is the only number spelled with letters in alphabetical order?", 40, 40);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe, and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge($"What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
                1) John
                2) Paul
                3) George
                4) Ringo
            ",
                4, 20
            );

            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            //Make a new adventurer object using the Adventurer class
            // prompt the user for their name 
            Console.WriteLine("What is your Adventurer's Name?");
            string AdventurerName = Console.ReadLine();

            // In Program.cs create a new instance of the Robe class and set its properties.
            // Pass the new Robe into the constructor of the Adventurer.
            //Before the adventurer starts their challenge, call the GetDescription method and print the results to the console.
            List<string> colors = new List<string>() { "red", "blue", "yellow" };

            Robe AdventurerRobe = new Robe()
            {
                Colors = colors,
                Length = 3
            };

            Hat AdventurerHat = new Hat()
            {
                ShininessLevel = 6
            };
            Prize AdventurerPrize = new Prize("Your awesomeness is outstanding!!!");

            //and pass that name to the Adventurer constructor when creating the new Adventurer object.
            int correctAnswers = 0;
            Adventurer theAdventurer = new Adventurer(AdventurerName, AdventurerRobe, AdventurerHat);

            int Roll(int i)
            {
                int randomNumber = new Random().Next(0, i);
                return randomNumber;
            }


            Console.WriteLine(theAdventurer.GetDescription());
            bool playAgain = true;
            while (playAgain)
            {

                List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo, theAnswer, whatSecond, guessRandom, favoriteBeatle, howManyStates, noRoman, popularNumber, luckiestNumber, howManyContinents, alphabetNumber
            };
                theAdventurer.Awesomeness = theAdventurer.Awesomeness + (correctAnswers * 10);
                Console.WriteLine($"{theAdventurer.Name}, your awesomeness level is {theAdventurer.Awesomeness}.");
                List<int> challengeList = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    challengeList.Add(Roll(challenges.Count));
                }
                // Loop through all the challenges and subject the Adventurer to them
                foreach (int index in challengeList)
                {
                    challenges[index].RunChallenge(theAdventurer);
                }

                // This code examines how Awesome the Adventurer is after completing the challenges
                // And praises or humiliates them accordingly
                if (theAdventurer.Awesomeness >= maxAwesomeness)
                {
                    Console.WriteLine("YOU DID IT! You are truly awesome!");
                }
                else if (theAdventurer.Awesomeness <= minAwesomeness)
                {
                    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                }
                else
                {
                    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                }

                AdventurerPrize.ShowPrize(theAdventurer);

                Console.WriteLine($"{theAdventurer.Name}, Would you like to play again? Y/N");
                string playAnswer = Console.ReadLine();
                if (playAnswer.ToLower() == "y")
                {
                    playAgain = true;
                    Console.Clear();

                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Thank you for playing.");
                }



            }
        }
    }
}

