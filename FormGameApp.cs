using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaydensApp
{
    public partial class FormGameApp : Form
    {
        public FormGameApp()
        {
            InitializeComponent();
        }

        // Global variables
        public string Game_Name = "";

        /// <summary>
        /// Plays the game that the user chooses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            Program.PlayersName = TbxPlayersName.Text.TrimEnd();
            Game_Name = CbxGame.SelectedItem.ToString();
            PlayGame(Game_Name);
        } // End of BtnPlayGame_click

        /// <summary>
        /// Runs code to play a specific game depending on what the user chooses
        /// </summary>
        /// <param name="Game_Name"></param>
        public void PlayGame(string Game_Name)
        {
            string feedback = "";
            try
            {
                switch (Game_Name)
                {
                    case "Dice":
                        feedback = Program.PlayDiceGame(); break;
                    case "Ten Sided Dice": 
                        feedback = Program.PlayTenSidedDiceGame(); break;
                    case "Twenty Sided Dice":
                        feedback = Program.PlayTwentySidedDiceGame(); break;
                    case "High Card Wins":
                        feedback = PlayHighCardWins(); break;
                    case "Blackjack":
                        feedback = PlayBlackjackGame(); break;
                    default:
                        MessageBox.Show("Game not implemented", "Error"); break;
                }
                DisplayGameResult(Game_Name, feedback);
            } catch (Exception ex)
            {
                MessageBox.Show("Not implemented correctly" + ex.Message, "Exception Error");
            }
        } // End of PlayGame

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TbxPlayersName_TextChanged(object sender, EventArgs e)
        {
            if(TbxPlayersName.Text.Length > 1)
                CbxGame.Enabled = true;
        } // End of  TbxPlayersName_TextChanged

        private void CbxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
                BtnPlayGame.Enabled = true;
        } // End of CbxGame_SelectedIndexChanged

        /// <summary>
        /// Runs the DisplayOverallGameWinner method which calculates the player with the most wins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFindOverallWinner_Click(object sender, EventArgs e)
        {
            DisplayOverallGameWinner();
        } // End of BtnFindOverallWinner_Click

        /// <summary>
        /// Resets and clears any information in the game selection combo box
        /// </summary>
        private void ResetInterface()
        {
            TbxPlayersName.Text = "";
            CbxGame.SelectedIndex = -1;
            CbxGame.Enabled = false;
            BtnPlayGame.Enabled = false;
            LsvGameStatistics.Items.Clear();
        } // End of ResetInterface


        /// <summary>
        /// Fills the dropdown menu (combo box) with a list of the available games that are playable to the user
        /// </summary>
        private void FillCbxGame()
        {
            String[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice", "High Card Wins", "Blackjack" };
            CbxGame.Items.Clear();
            foreach (string game in availableGames)
                CbxGame.Items.Add(game);
        } // End of FillCbxGame

        /// <summary>
        /// Calculates who won the most games and displays it is a message box pop up window.
        /// If a draw occurs, that is also specified.
        /// </summary>
        private void DisplayOverallGameWinner()
        {
            int playerWins = 0;
            int computerWins = 0;
            string result = "";
            int numOfGames = LsvGameStatistics.Items.Count;

            foreach(ListViewItem element in LsvGameStatistics.Items)
            {
                result = element.SubItems[3].Text;
                if (result.StartsWith(Program.PlayersName))
                    playerWins += 1;
                else if (result.StartsWith("Computer"))
                    computerWins += 1;
            }
            if (playerWins > computerWins)
                result = $"{Program.PlayersName} wins as they can {playerWins} games, which is higher than the computer's number of wins.";
            else if (playerWins < computerWins)
                result = $"Computer wins  as they won {computerWins}, which is higher than {Program.PlayersName}'s number of wins";
            if (playerWins == computerWins)
                result = $"Draw, as both players won {computerWins} each";

            MessageBox.Show(result, "Overall result");
        } //  End of DIsplayOverallGameWinner

        /// <summary>
        /// Shows the game results, who won and what the score was, in a list view
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="feedback"></param>
        private void DisplayGameResult(string gameName, string feedback)
        {
            if (gameName != "Blackjack")
            {
                string[] row = { Game_Name, Program.PlayersScore.ToString(), Program.ComputerScore.ToString(), Program.Winner };
                var listViewItem = new ListViewItem(row);
                LsvGameStatistics.Items.Add(listViewItem);
                MessageBox.Show(feedback, $"{gameName} Result");
            }
            else
            {
                MessageBox.Show(feedback, $"{gameName} Next step");
            }
        } // End of DisplayGameResult


        private void Form1_Load(object sender, EventArgs e)
        {
            FillCbxGame();
            ResetInterface();

            //this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(CbxGame_SelectedIndexChanged);
        }

        // Playing Card Games
        Deck mainDeck = null;

        /// <summary>
        /// Plays the high card wins game
        /// Creates a new deck from the Deck constructor if the mainDeck variable is null
        /// Assigns the scores of both the player and the computer to their respective score labels
        /// </summary>
        /// <returns></returns>
        private string PlayHighCardWins()
        {
            if (mainDeck == null) mainDeck = new Deck();

            PlayingCard playerCard = mainDeck.Deal();
            Program.PlayersScore = playerCard.Value;
            LblPlayerScore.Text = Program.PlayersScore.ToString();
            PlayingCard computerCard = mainDeck.Deal();
            Program.ComputerScore = computerCard.Value;
            LblComputerScore.Text = Program.ComputerScore.ToString();

            return Program.FindGameWinner();
        }

        // Blackjack
        Hand ComputerHand = null;
        Hand PlayerHand = null;


        /// <summary>
        /// This function deals a player a card from the deck.
        /// If the mainDeck is null, it creates a new deck from the Deck class.
        /// If the PlayerHand is null, it creates a new hand from the Hand class.
        /// Following this, the playerCard is initialized with cards from the mainDeck,
        /// using the Deal method.
        /// These cards are then added to the hand of the player using the AddCardToHand method,
        /// using the playerCard as the argument.
        /// The player card is then displayed on the interface,
        /// once again using the playerCard as the argument.
        /// </summary>
        public void DealPlayerCard()
        {
            if(mainDeck == null)
                mainDeck = new Deck();
            if(PlayerHand == null)
                PlayerHand = new Hand();

            PlayingCard playerCard = mainDeck.Deal();
            PlayerHand.AddCardToHand(playerCard);
            DisplayPlayerCard(playerCard);
        } // End of DealPlayerCard

        /// <summary>
        /// Deals the computer a card and adds it to the computer's hand
        /// </summary>
        public void DealComputerCard()
        {
            if (mainDeck == null)
                mainDeck = new Deck();
            if (ComputerHand == null)
                ComputerHand = new Hand();

            PlayingCard computerCard = mainDeck.Deal();
            ComputerHand.AddCardToHand(computerCard);
            DisplayComputerCard(computerCard);
        } // End of DealComputerCard

        /// <summary>
        /// Shows the player's card face and suit in the player hand list view
        /// </summary>
        /// <param name="card"></param>
        private void DisplayPlayerCard(PlayingCard card)
        {
            try
            {
                LsvPlayerHand.Items.Add(new ListViewItem(new[] { card.Face.ToString(), card.Suit.ToString() }));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Display card error");
            }
        }

        /// <summary>
        /// Shows the computer's card face and suit in the computer hand list view
        /// </summary>
        /// <param name="card"></param>
        private void DisplayComputerCard(PlayingCard card)
        {
            try
            {
                LsvComputerHand.Items.Add(new ListViewItem(new[] { card.Face.ToString(), card.Suit.ToString() }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display card error");
            }
        }

        /// <summary>
        /// Deals the computer 2 cards and shows the score in the computer score label
        /// </summary>
        private void DealaComputerHand()
        {
            DealComputerCard();
            DealComputerCard();

            Program.ComputerScore = ComputerHand.GetHandValue();
            LblComputerScore.Text = Program.ComputerScore.ToString();
        }


        /// <summary>
        /// This function deals deals both players a card,
        /// then sets their scores to the value of their hand
        /// using the GetHandValue method.
        /// </summary>
        /// <returns></returns>
        public string PlayBlackjackGame()
        {
            DealPlayerCard();
            DealPlayerCard();

            Program.PlayersScore = PlayerHand.GetHandValue();
            LblPlayerScore.Text = Program.PlayersScore.ToString();
            //Program.ComputerScore = ComputerHand.GetHandValue();
            //LblComputerScore.Text = Program.ComputerScore.ToString();

            return "Select Hit or Stand";
        }
        /// <summary>
        /// Deals a 3rd card to the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHit_Click(object sender, EventArgs e)
        {
            try
            {
                DealPlayerCard();
                Program.PlayersScore = PlayerHand.GetHandValue();
                LblPlayerScore.Text = Program.PlayersScore.ToString();

                if(Program.PlayersScore > 21)
                {
                    BtnStand_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display BtnHit Error");
            }
        }
        /// <summary>
        /// Deals a hand to the computer depending on the current score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStand_Click(object sender, EventArgs e)
        {
            try
            {
                DealaComputerHand();

                Program.ComputerScore = PlayerHand.GetHandValue();
                LblComputerScore.Text = Program.ComputerScore.ToString();

                while(Program.ComputerScore < 17)
                {
                    DealaComputerHand();
                    Program.ComputerScore = PlayerHand.GetHandValue();
                    LblComputerScore.Text = Program.ComputerScore.ToString();
                }

                if (Program.ComputerScore >= 17)
                {
                    string feedback = FindBlackJackGameWinner();
                    DisplayGameResult("Blackjack", feedback);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error with stand");
            }
        }

        /// <summary>
        /// Calculates who won the Blackjack game by comparing the scores of the two players
        /// </summary>
        /// <returns></returns>
        private string FindBlackJackGameWinner()
        {
            string feedback = "";

            if (Program.PlayersScore > Program.ComputerScore)
                feedback = $"{Program.PlayersName} wins as {Program.PlayersScore} is higher than {Program.ComputerScore}";
            else if (Program.PlayersScore < Program.ComputerScore)
                feedback = $"Computer wins as {Program.ComputerScore} is higher than {Program.PlayersScore}";
            else if (Program.PlayersScore == Program.ComputerScore)
                feedback = $"Draw as both players achieved an equal score.";

            return feedback;
        }

        // ignore
        private void LblPlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void LblComputerScore_Click(object sender, EventArgs e)
        {

        }

        private void LsvGameStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    } // end of form
}
