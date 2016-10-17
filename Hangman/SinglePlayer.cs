using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class SinglePlayer
    {
        private string player;
        private int playerScore;
        private int tries;
        private int rounds;
        private string word;
        private string guessWord;

        private char[] chars;
        private char[] guessChars;

        List<char> usedList = new List<char>();

        public SinglePlayer()
        {
            this.player = "Player";
            this.playerScore = 0;
            this.tries = 7;
            this.guessWord = "";
        }

        public SinglePlayer(string player)
        {
            this.player = player;
            this.playerScore = 0;
            this.tries = 7;
            this.guessWord = "";
        }

        public void initialize()
        {
            this.tries = 7;
            this.guessWord = "";
            usedList.Clear();
        }
        public void initialScore()
        {
            this.playerScore = 0;
        }
        public int getWordLength()
        {
            return word.Length;
        }

        public void printGameName()
        {
            Console.Clear();
            Console.WriteLine();
            string str = "Hangman Game Single Player!!!";
            string under = "------------------------------------";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}", str));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (under.Length / 2)) + "}", under));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (under.Length / 2)) + "}", under));
        }

        public void setString()
        {
            List<int> randomList = new List<int>();
            string line="",l;
            int count = 0;
            int n = 0;

            Random index = new Random();
            n = index.Next() % 10000;

            System.IO.StreamReader file = new System.IO.StreamReader("E:/MY_WORKPLACE/C#/Hangman/Hangman/input.txt");
            while ((l = file.ReadLine()) != null)
            {
                if (count == n)
                {
                    line = l;
                }
                count++;
            }

            string str = line;
            int len = str.Length;
            for(int i = 0; i < len/3; i++)
            {
                n = index.Next() % len;
                
                if (!randomList.Contains(n) && !randomList.Contains(n-1) && !randomList.Contains(n+1))
                {
                    randomList.Add(n);
                }
            }
             
            Console.WriteLine();
            word = str;
            for (int i = 0; i < word.Length; i++)
            {
                guessWord += "-";
            }
            chars = word.ToCharArray();
            guessChars = guessWord.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (randomList.Contains(i))
                {
                    Console.WriteLine(i);
                    guessChars[i] = word[i];
                }
                   
            }

        }

        public void gameInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Tries: {0}", this.tries);
            Console.WriteLine();
            Console.WriteLine("Length: {0}", this.getWordLength());
            Console.WriteLine();
            Console.Write("Used: ");
            for (int i = 0; i < usedList.Count; i++)
            {
                Console.Write(usedList[i]);
            }
            Console.WriteLine();
        }

        public void searchString(char s)
        {
            int flag = 0;
            for (int i = 0; i < getWordLength(); i++)
            {
                if (chars[i] == s)
                {
                    guessChars[i] = s;
                    flag = 1;
                }
                if (!usedList.Contains(s))
                {
                    usedList.Add(s);
                }
                guessWord = new string(guessChars);
            }
            if (flag == 0)
            {
                tries--;
            }
        }

        public bool checkResult()
        {
            if (word == guessWord)
            {
                playerScore++;
                return true;
            }

            else if (word == guessWord)
            {
                playerScore++;
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
            Console.WriteLine("Tries Left: " + tries);
            Console.WriteLine();
            Console.WriteLine(player + " : " + playerScore);

        }

        public void showFinalResult()
        {
            printGameName();

            Console.WriteLine();
            Console.WriteLine("Toal Round : " + rounds);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(player + " Score : " + playerScore);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Results : ");
            Console.WriteLine("Draw");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void play()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(guessWord);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Guess a Word: ");
            char s = Char.Parse(Console.ReadLine());
            searchString(s);
        }

        public void StartGame()
        {
            initialScore();
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
                Console.WriteLine(player + " : " + playerScore);
                Console.WriteLine();
                setString();

                bool res = false;
                while (tries != 0)
                {
                    printGameName();
                    gameInfo();
                    play();
                    res = checkResult();
                    if (res)
                        break;
                }
            }

            if (j == rounds)
            {
                showFinalResult();
            }
        }
    }
}