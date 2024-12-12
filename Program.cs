
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaydensApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGameApp());

            //Greeting();
            //PlayGames();
            //Finish();
        } // End of Main

        static public void Greeting()
        {
            string message = "Welcome ";
            PlayersName = GetText("What is your name");
            Console.WriteLine(message + PlayersName);
        }

        static public string GetText(string prompt)
        {
            string text = "";
            do
            {
                Console.WriteLine(prompt);
                text = Console.ReadLine();
                if (text == "")
                    Console.WriteLine("You must enter a name, try again\n");
            } while (text == "");

            return text;
        } // End of GetText


        /// <summary>
        /// Play guessing game
        /// Get computer's random guess
        /// Get user guess
        /// Check guess and get feedback
        /// display feedback
        /// </summary>

        static public string PlayGuessingGameV1(int answer)
        {
            int userGuess;
            int max = 10;
            string prompt = $"Guess a number between 0 and {max}";
            string feedback;

            
            userGuess = GetInt(prompt, max);
            feedback = CheckGuess(userGuess, answer);
            return feedback;
        } // PlayGuessingGameV1

        static public string PlayGuessingGameV2()
        {
            int max = 10;
            string prompt = $"Guess a number between 0 and {max}";
            string feedback = "";
            int attempt = 0;
            int answer = 0;
            answer = GenerateNumber(max);

            do
            {
                attempt++;
                feedback = PlayGuessingGameV1(answer);
                Console.WriteLine(feedback);
            } while ((attempt < 3) && (feedback.StartsWith("Error")));
            if (!feedback.StartsWith("Error"))
                feedback = $"You win as you guessed correctly in {attempt} attempt(s) \n";
            else
                feedback = $"You lost as you didn't guess in 3 attempts \n";
            return feedback;
        } // End of PlayGuessingGameV2

        static Random random = new Random();

        static public int GenerateNumber(int max)
        {
            int num = random.Next(0, max);
            return num;
        } // End of GenerateNumber

        static public int GetInt(string prompt, int max)
        {
            string text = "";
            int num;
            text = GetText(prompt);
            num = int.Parse(text);
            return num;
        } // End of GetInt

        static public string CheckGuess(int userGuess, int answer)
        {
            string feedback = "";

            if (userGuess == answer)
                feedback = $"Congratulations you guessed {userGuess} which matches {answer} correctly!";
            else if (userGuess > answer)
                feedback = $"Error, you guessed {userGuess} too high, you lose!";
            else if (userGuess < answer)
                feedback = $"Error, you guessed {userGuess} too low, you lose!";

            return feedback;
        }

        static public void PlayGames()
        {
            string choice;
            string feedback = "";

            do
            {
                choice = GetMenuChoice(" 1 - Guessing Game, 2 - Dice, 3 - Ten Sided Dice");

                if (choice == "1")
                    feedback = PlayGuessingGameV2();
                else if (choice == "2")
                    feedback = PlayDiceGame();
                else if (choice == "3")
                    feedback = PlayTenSidedDiceGame();

                Console.Write("\n" + feedback);

            } while (choice != "0");

            
        } // End of PlayGames

        static public string GetMenuChoice(string availableGames)
        {
            string choice;
            string[] games = availableGames.Split(',');
            string menu = "";
            for (int i = 0; i <= (games.Length - 1); i++)
            {
                menu += games[i] + "\n";
            };
            menu += "Enter a menu choice. 1, 2, 3, or 0 to exit.";
            choice = GetText(menu);
            return choice;
        }

        //static string feedback = "";
        public static string PlayersName = "";
        public static int PlayersScore = 0;
        public static int ComputerScore = 0;
        public static string Winner = "";

        public static string PlayDiceGame()
        {
            string feedback = "";
            try
            {
                Dice playerDice = new Dice("Blue");
                Dice computerDice = new Dice("Red");
                PlayersScore = playerDice.Num;
                ComputerScore = computerDice.Num;
                feedback = $"Player Rolled {playerDice}, computer rolled {computerDice} \nResult: ";
                feedback += FindGameWinner();

            } catch (Exception ex) {
                feedback = "Not implemented correctly";
            }
            return feedback;
        }

        public static string PlayTenSidedDiceGame()
        {
            string feedback = "";
            try
            {
                TenSidedDice playerDice = new TenSidedDice("Blue");
                TenSidedDice computerDice = new TenSidedDice("Red");
                PlayersScore = playerDice.Num;
                ComputerScore = computerDice.Num;
                feedback = $"Player Rolled {playerDice}, computer rolled {computerDice} \nResult: ";
                feedback += FindGameWinner();

            }
            catch (Exception ex)
            {
                feedback = "Not implemented correctly";
            }
            return feedback;
        }

        public static string PlayTwentySidedDiceGame()
        {
            string feedback = "";
            try
            {
                TwentySidedDice playerDice = new TwentySidedDice("Blue");
                TwentySidedDice computerDice = new TwentySidedDice("Red");
                PlayersScore = playerDice.Num;
                ComputerScore = computerDice.Num;
                feedback = $"Player Rolled {playerDice}, computer rolled {computerDice} \nResult: ";
                feedback += FindGameWinner();
            } catch (Exception ex)
            {
                feedback = "Not implemented correctly";
            }
            return feedback;
        }


        public static string FindGameWinner()
        {
            string feedback = "";

            if (PlayersScore == ComputerScore)
            {
                feedback = $"Draw as {PlayersScore} was equal to {ComputerScore}";
                Winner = "Draw";
            }
            else if (PlayersScore > ComputerScore)
            {
                feedback = $"{PlayersName} wins as {PlayersScore} is higher than {ComputerScore}";
                Winner = "Player";
            }
            else if (PlayersScore < ComputerScore)
            {
                feedback = $"Computer wins as {ComputerScore} is higher than {PlayersScore}";
                Winner = "Computer";
            }
            return feedback + "\n\n";
        }

        static public void Finish()
        {
            Console.WriteLine("Press Enter key to exit app");
            Console.Read();
        } // End of Finish
    } // No code after the second to last squiggly brace

}