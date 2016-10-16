using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class MultiPlayer
    {
        private string player1;
        private string player2;
        private int turnController;
        private string turn;
        private int playerOneScore;
        private int playerTwoScore;
        private int tries;

        private String word;
        private string guessWord;
        private string w;
        private char[] chars;
        private char[] guessChars;


        public MultiPlayer()
        {
            this.player1 = "Player 1";
            this.player2 = "Player 2";
            this.turn = "playerOne";
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
            this.turnController = 0;
            this.tries = 7;
            this.word = "AIUBCSEB2";
            this.guessWord = "";
        }

        public MultiPlayer(string player1,string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.turn = "playerOne";
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
            this.turnController = 0;
            this.tries = 7;
            this.word = "AIUBCSEB2";
            this.guessWord = "";
        }

        public void printGameName()
        {
            Console.Clear();
            string str = "Hangman Game Multiplayer!!!";
            string under = "------------------------------------";
            Console.Clear();

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}", str));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (under.Length / 2)) + "}", under));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (under.Length / 2)) + "}", under));
        }

        public int getWordLength()
        {
            return word.Length;
        }

        public void setTurn()
        {
            if(turnController%2==0)
            {
                turn= "playerOne";
                turnController++;
            }
            else
            {
                turn = "playerTwo";
                turnController++;
            }
            if (turn == "playerOne")
                Console.WriteLine("{0} Give Word !!!",player1);
            else
                Console.WriteLine("{0} Guess the word !!!",player2);
        }

        public void setString()
        {
            Console.Write("Enter a word : ");
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                guessWord += "-";
            }
            chars = word.ToCharArray();
            guessChars = guessWord.ToCharArray();
        }

        public void randomGenerator()
        {
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            int n = rnd.Next(1, getWordLength());
            Console.WriteLine(n);
        }

        public void searchString(char s)
        {
            for(int i = 0; i < getWordLength(); i++)
            {
                if (chars[i] == s)
                {
                    guessChars[i]= s;
                }
            }
            guessWord = new string(guessChars);
            Console.WriteLine(guessWord);
        }

        public void checkResult()
        {
            
        }

        public void drawHangman()
        {

        }

        public void showResult()
        {

        }

        public void showFinalResult()
        {

        }
        public void StartGame()
        {
            printGameName();
            randomGenerator();
            setString();
            searchString('i');

            for (int i = 0; i < tries; i++)
            {

                
            }
            
        }



    }
}
