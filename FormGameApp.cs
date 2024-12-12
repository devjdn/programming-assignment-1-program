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

        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            Program.PlayersName = TbxPlayersName.Text.TrimEnd();
            Game_Name = CbxGame.SelectedItem.ToString();
            PlayGame(Game_Name);
        }

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
                    default:
                        MessageBox.Show("Game not implemented", "Error"); break;
                }
                DisplayGameResult(Game_Name, feedback);
            } catch (Exception ex)
            {
                MessageBox.Show("Not implemented correctly" + ex.Message, "Exception Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TbxPlayersName_TextChanged(object sender, EventArgs e)
        {
            if(TbxPlayersName.Text.Length > 1)
                CbxGame.Enabled = true;
        }
        
        private void CbxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
                BtnPlayGame.Enabled = true;
        }

        private void BtnFindOverallWinner_Click(object sender, EventArgs e)
        {
            DisplayOverallGameWinner();
        }

        private void ResetInterface()
        {
            TbxPlayersName.Text = "";
            CbxGame.SelectedIndex = -1;
            CbxGame.Enabled = false;
            BtnPlayGame.Enabled = false;
            LsvGameStatistics.Items.Clear();
        }
        /// <summary>
        /// FillCbxGame combo-box with availableGames from String array
        /// a.) Declare 
        /// </summary>
        private void FillCbxGame()
        {
            String[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice", "High Card Wins", "Black Jack" };
            CbxGame.Items.Clear();
            foreach (string game in availableGames)
                CbxGame.Items.Add(game);
        }

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
        }

        private void DisplayGameResult(string gameName, string feedback)
        {
            string[] row = { Game_Name, Program.PlayersScore.ToString(), Program.ComputerScore.ToString(), Program.Winner };
            var listViewItem = new ListViewItem(row);
            LsvGameStatistics.Items.Add(listViewItem);
            MessageBox.Show(feedback, $"{gameName} Result");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FillCbxGame();
            ResetInterface();

            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(CbxGame_SelectedIndexChanged);
        }

        // Playing Card Games
        Deck mainDeck = null;

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

        public void DealPlayerCard()
        {
            if(mainDeck == null)
                mainDeck = new Deck();
            if(PlayerHand == null)
                PlayerHand = new Hand();

            PlayingCard playerCard = mainDeck.Deal();
            PlayerHand.AddCardToHand(playerCard);
            DisplayPlayerCard(playerCard);
        }

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

        public string PlayBlackjackGame()
        {
            DealPlayerCard();
            DealPlayerCard();

            Program.PlayersScore = PlayerHand.GetHandValue();
            LblPlayerScore.Text = PlayerScore.ToString();

            return "Select Hit or Stand";
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
