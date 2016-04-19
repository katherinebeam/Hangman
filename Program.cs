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
           
            prompter.Play();
        }
    }
}
