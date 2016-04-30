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
       //loop through game play and show progress after each guess while user still has tries remaining
       public void Play()
       {
           while(HangManGame.GetRemainingTries() > 0 && !HangManGame.IsSolved())
           {
               ShowProgress();
               PromptForGuess();
           }
           if(HangManGame.IsSolved())
           {
               Console.WriteLine("Congratulations! You won with {0} tries remaining.", HangManGame.GetRemainingTries());
           }
           else
           {
               Console.WriteLine("Whoops! You lose! The word was '{0}'. :(", HangManGame.GetAnswer());
           }
       }
       
       //Prompt user for guess, then check if answer contains their guessed letter
       public bool PromptForGuess()
       {
           bool isHit = false;
           bool isValidGuess = false;
           
           while(!isValidGuess)
           {
                Console.WriteLine("Enter a letter:");
                string guessAsString = Console.ReadLine();
                try 
                {
                    isHit = this.HangManGame.CheckGuess(guessAsString);
                    isValidGuess = true;
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine("{0} Please try again.", ae.Message);
                }
           }
           return isHit;
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
