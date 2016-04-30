using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Game
    {
        //PROPERTIES
        //setting constant for most wrong guesses allowed in a game to 7
        public const int MAX_MISSES = 7;
        private string Answer { get; set; }
        public string CorrectGuesses { get; set; }
        public string WrongGuesses { get; set; }
        
        //METHODS
        //check whether user's guess is in answer or not
        public bool CheckGuess(char letter)
        {
            letter = ValidateGuess(letter);
            bool charIsInAnswer = this.Answer.IndexOf(letter) >= 0;
            if(charIsInAnswer)
            {
                this.CorrectGuesses += letter;
            }
            else 
            {
                this.WrongGuesses += letter;
            }
            return charIsInAnswer;
        }
        
        //checks how many correct/incorrect guesses the user has made
        public string CurrentProgress()
        {
            string progress = "";
            foreach(char letter in this.Answer.ToCharArray())
            {
                char display = '-';
                if(this.CorrectGuesses.IndexOf(letter) >= 0)
                {
                    display = letter;
                }
                progress += display;
            }
            return progress;
        }
        
        public int GetRemainingTries()
        {
            return MAX_MISSES - WrongGuesses.Length;
        }
        
        private char ValidateGuess(char letter) 
        {
            if(!Char.IsLetter(letter))
            {
                throw new ArgumentException("A letter is required.");
            }            
            letter = Char.ToLower(letter);
            if(WrongGuesses.IndexOf(letter) >= 0 || CorrectGuesses.IndexOf(letter) >= 0) 
            {
                throw new ArgumentException("{0} has already been guessed.", letter.ToString());
            }
            return letter;
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
