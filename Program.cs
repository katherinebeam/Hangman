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
            //instantiate new Game object
            Game game = new Game("spaceship");
            
            //instantiate new Prompter object
            Prompter prompter = new Prompter(game);
           
            //prompt user for guess and tell user whether or not the letter they guessed is in the answer
            bool GoodGuess = prompter.PromptForGuess();
            if(GoodGuess)
            {
                Console.WriteLine("We got a hit!");
            }
            else
            {
                Console.WriteLine("Whoops! You missed.");
            }
        }
    }
}
