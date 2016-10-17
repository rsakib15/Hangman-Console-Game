﻿using System;
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
        private int setter = 0;

        private int playerOneScore;
        private int playerTwoScore;

        private int tries;
        private int rounds;

        private String word;
        private string guessWord;
        private char[] chars;
        private char[] guessChars;
    
        public MultiPlayer()
        {
            this.player1 = "Player 1";
            this.player2 = "Player 2";
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
            this.tries = 7;
            this.guessWord = "";
        }

        public MultiPlayer(string player1,string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
            this.tries = 7;
            this.guessWord = "";
        }

        public void initialize()
        {
            this.tries = 7;
            this.guessWord = "";
        }
        public void initializeScore()
        {
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
        }
        public int getWordLength()
        {
            return word.Length;
        }

        public void printGameName()
        {
            Console.Clear();
            Console.WriteLine();
            string str = "Hangman Game Multiplayer!!!";
            string under = "------------------------------------";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}", str));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (under.Length / 2)) + "}", under));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (under.Length / 2)) + "}", under));
        }

        public void setString()
        {
            Console.WriteLine();
            Console.Write("Enter a word : ");
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                guessWord += "-";
            }
            chars = word.ToCharArray();
            guessChars = guessWord.ToCharArray();
        }

        public void PrintQuestion()
        {
            if (setter == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Player Name: {0}", this.player1);
            }
            else if (setter==1)
            {
                Console.WriteLine();
                Console.WriteLine("Player Name: {0}", this.player2);
            }
        }

        public void PrintAnswer()
        {
            if (setter == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Player Name: {0}", this.player2);
            }
            else if (setter == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Player Name: {0}", this.player1);
            }
        }

        public void gameInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Tries: {0}",this.tries);
            Console.WriteLine();
            Console.WriteLine("Length: {0}", this.getWordLength());
            Console.WriteLine();
            Console.WriteLine("Used: {0}" , this.tries);
        }
        
        public void randomGenerator()
        {
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            int n = rnd.Next(1, getWordLength());
            Console.WriteLine(n);
        }

        public void searchString(char s)
        {
            int flag = 0;
            for(int i = 0; i < getWordLength(); i++)
            {
                if (chars[i] == s)
                {
                    guessChars[i]= s;
                    flag = 1;
                }
                guessWord = new string(guessChars);
                Console.WriteLine(guessWord);
                Console.WriteLine(word);
            }
            if(flag==0)
            {
                tries--;
            }
        }

        public bool checkResult()
        {
            if (word == guessWord && setter==1)
            {
                playerOneScore++;
                return true;
            }

            else if (word == guessWord && setter == 0)
            {
                playerTwoScore++;
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public void showResult()
        {
            Console.Clear();
            printGameName();

            Console.WriteLine();
            Console.WriteLine();
            PrintAnswer();
            Console.WriteLine("Tries Left: " + tries);
            Console.WriteLine();
            Console.WriteLine(player1 + " : " + playerOneScore);
            Console.WriteLine();
            Console.WriteLine(player2 + " : " + playerTwoScore);

        }

        public void showFinalResult()
        {
            printGameName();

            Console.WriteLine();
            Console.WriteLine("Toal Round : " + rounds);
            Console.WriteLine();
            Console.WriteLine(player1 + " Score : " + playerOneScore);
            Console.WriteLine();
            Console.WriteLine(player2 + " Score : " + playerTwoScore);

            if (playerOneScore > playerTwoScore)
                Console.WriteLine(player1 + " Win");
            else if (playerOneScore < playerTwoScore)
                Console.WriteLine(player2 + " Win");
            else
                Console.WriteLine("Draw");
        }

        public void play()
        {
            Console.WriteLine(guessWord);
            char s = Char.Parse(Console.ReadLine());
            searchString(s);
        }

        public void StartGame()
        {
            initializeScore();
            printGameName();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("How many Round you want to play ? : ");
            rounds = Convert.ToInt32(Console.ReadLine());

            int j;
            for (j = 0; j < this.rounds; j++)
            {
                initialize();
                printGameName();
                Console.WriteLine();
                Console.WriteLine("Round : " + (j + 1));
                Console.WriteLine();
                Console.WriteLine(player1 + " : " + playerOneScore);
                Console.WriteLine();
                Console.WriteLine(player2 + " : " + playerTwoScore);
                PrintQuestion();
                setString();

                bool res = false;
                while (tries!=0)
                {
                    printGameName();
                    PrintAnswer();
                    gameInfo();
                    play();
                    res=checkResult();
                    if (res)
                        break;
                }

                if ((tries == 0 && setter == 1) || (res && setter == 1))
                    setter = 0;
                else if (tries == 0 && setter == 0 || (res &&  setter == 0))
                    setter = 1;
            }
            if(j==rounds)
            {
                showFinalResult();
            }
        }
    }
}