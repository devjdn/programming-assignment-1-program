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
            //Application.Run(new Form1());

            Greeting();
            PlayGames();
            Finish();
        } // End of Main

        static public void Greeting()
        {
            string message = "Welcome ";
            string name;
            name = GetText("What is your name");
            Console.WriteLine(message + name);
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

        static public string PlayGuessingGameV1()
        {
            int answer;
            int userGuess;
            int max = 10;
            string prompt = $"Guess a number between 0 and {max}";
            string feedback;

            answer = GenerateNumber(max);
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

            do
            {
                attempt++;
                feedback = PlayGuessingGameV1();
                Console.WriteLine(feedback);
            } while ((attempt <= 3) && (feedback.StartsWith("Error")));
            if (attempt <= 3)
                feedback = $"You win as you guessed correctly in {attempt} attempt(s)";
            else
                feedback = $"You lost as you didn't guess in 3 attempts";
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
            } while (choice != "0");

            Console.Write("\n" + feedback);
        } // End of PlayGames

        static public string GetMenuChoice(string availableGames)
        {
            string choice;
            string[] games = availableGames.Split(',');
            string menu = "";
            for(int i = 0; i <= (games.Length - 1); i++)
            {
                menu += games[i] + "\n";
            }
            menu += "Enter a menu choice. 1, 2, 3, or 0 to exit.";
            choice = GetText(menu);
            return choice;
        }

        static public string PlayDiceGame()
        {
            return "Dice Game has not been made yet";
        }

        static public string PlayTenSidedDiceGame()
        {
            return "Ten Sided Dice Game has not been made yet";
        }

        static public void Finish()
        {
            Console.WriteLine("Press Enter key to exit app");
            Console.Read();
        } // End of Finish
    } // No code after the second to last squiggly brace

}