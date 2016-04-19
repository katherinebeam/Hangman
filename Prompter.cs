using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;


namespace HangmanGame
{
    class Prompter
    {        
       //PROPERTIES
       public Game HangManGame { get; set; }
       
       //METHODS
       //loop through game play and show progress after each guess whileuser still has tries remaining
       public void Play()
       {
           while(HangManGame.GetRemainingTries() > 0)
           {
               ShowProgress();
               PromptForGuess();
           }
       }
       
       //Prompt user for guess, then check if answer contaisn their guessed character
       public bool PromptForGuess()
       {
           Console.WriteLine("Enter a letter:");
           string guessAsLetter = Console.ReadLine();
           char guess = Convert.ToChar(guessAsLetter[0]);
           return this.HangManGame.CheckGuess(guess);
       }
       
       public void ShowProgress()
       {
           Console.WriteLine("You have {0} tries left to solve: {1}", HangManGame.GetRemainingTries(), this.HangManGame.CurrentProgress());
       }
       
       //CONSTRUCTORS
       public Prompter(Game game)
       {
           this.HangManGame = game;
       }
    }
}
