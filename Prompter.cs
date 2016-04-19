using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HangmanGame
{
    class Prompter
    {        
       //PROPERTIES
       public Game HangManGame { get; set; }
       
       //METHODS
       
       //Prompt user for guess, then check if answer contaisn their guessed character
       public bool PromptForGuess()
       {
           Console.WriteLine("Enter a letter:");
           string guessAsLetter = Console.ReadLine();
           char guess = Convert.ToChar(guessAsLetter[0]);
           return this.HangManGame.CheckGuess(guess);
       }
       
       //CONSTRUCTORS
       public Prompter(Game game)
       {
           this.HangManGame = game;
       }
    }
}
