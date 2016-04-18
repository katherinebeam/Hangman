using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Game
    {
        //Properties
        public string Answer { get; }
        public string CorrectGuesses { get; set; }
        public string WrongGuesses { get; set; }
        
        //METHODS
        //check whether user's guess is in answer or not
        public bool CheckGuess(char letter)
        {
            bool charIsInAnser = this.Answer.IndexOf(letter) >= 0;
            if(charIsInAnser)
            {
                this.CorrectGuesses += letter;
            }
            else 
            {
                this.WrongGuesses += letter;
            }
            return charIsInAnser;
        }
        
        //CONSTRUCTOR
        //ensure an answer/guess is passed in by the user when a new game is started
        public Game(string answer)
        {
            this.Answer = answer;
            this.CorrectGuesses = "";
            this.WrongGuesses = "";
        }
    }
}
