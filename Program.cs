using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //instantiate new object of type Game
            Game game = new Game("spaceship");
            //prompt user for their letter guess
            System.Console.WriteLine("Guess a letter:");
            //tell user whether or not the letter they guesses is in the answer
            System.Console.WriteLine(game.CheckGuess(Convert.ToChar(Console.ReadLine())));
        }
    }
}
