using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome to Hangman Game !!!";
            string underline = "------------------------------------";
            Console.Clear();
<<<<<<< HEAD
            Console.WriteLine();
=======

>>>>>>> 21f4fcf2027a0349d3a26c45f0543b68f2203bd3
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (underline.Length / 2)) + "}", underline));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (underline.Length / 2)) + "}", underline));
            Console.WriteLine();
            Console.WriteLine();

            //Select the how many Player
<<<<<<< HEAD

=======
            
>>>>>>> 21f4fcf2027a0349d3a26c45f0543b68f2203bd3
            Console.WriteLine("1. Single Player");
            Console.WriteLine("2. Multi Player");
            Console.WriteLine();
            Console.WriteLine();

            //Choose Option
            Console.Write("Choose an Option(1 or 2): ");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                //Single Player Game
                string str = "Hangman Game !!!";
                string under = "------------------------------------";
                Console.Clear();
<<<<<<< HEAD
                Console.WriteLine();
=======
            
>>>>>>> 21f4fcf2027a0349d3a26c45f0543b68f2203bd3
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}", str));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (underline.Length / 2)) + "}", under));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (underline.Length / 2)) + "}", under));

            }
<<<<<<< HEAD
            else if (choose == "2")
            {
                string player1, player2;
                //Multiplayer Game
                Console.Clear();

                string str = "Hangman Game Multiplayer!!!";
                string under = "------------------------------------";
                Console.Clear();
                Console.WriteLine();
=======
            else if(choose == "2")
            {
                string player1,player2;
                //Multiplayer Game
                Console.Clear();
                string str = "Hangman Game Multiplayer!!!";
                string under = "------------------------------------";
                Console.Clear();

>>>>>>> 21f4fcf2027a0349d3a26c45f0543b68f2203bd3
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}", str));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (underline.Length / 2)) + "}", under));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (underline.Length / 2)) + "}", under));

<<<<<<< HEAD
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Set Player 1 Name: ");
                player1 = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Set Player 2 Name: ");
                player2 = Console.ReadLine();

                Console.Clear();

                MultiPlayer multiPlayer = new MultiPlayer(player1, player2);
                multiPlayer.StartGame();
            }

            else
            {
                MultiPlayer multiPlayer = new MultiPlayer();
                multiPlayer.StartGame();
=======
                Console.Write("Enter Player 1 Name: ");
                player1 = Console.ReadLine();
                Console.Write("Enter Player 2 Name: ");
                player2 = Console.ReadLine();
                Console.Clear();

                MultiPlayer multiPlayer = new MultiPlayer(player1,player2);
                multiPlayer.StartGame();

            }
            else
            {
   
                MultiPlayer multiPlayer = new MultiPlayer();
                for (int i = 0; i < 100; i++)
                {
                    multiPlayer.StartGame();
                }
>>>>>>> 21f4fcf2027a0349d3a26c45f0543b68f2203bd3
            }
        }
    }
}