namespace JaydensApp
{
    partial class FormGameApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxPlayersName = new System.Windows.Forms.TextBox();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.GameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Winner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LsvComputerHand = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvPlayerHand = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnStand = new System.Windows.Forms.Button();
            this.BtnHit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayGame.Location = new System.Drawing.Point(12, 150);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(145, 35);
            this.BtnPlayGame.TabIndex = 0;
            this.BtnPlayGame.Text = "Play Game";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            // 
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(578, 102);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(173, 35);
            this.BtnFindOverallWinner.TabIndex = 1;
            this.BtnFindOverallWinner.Text = "Find Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = true;
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pick a game";
            // 
            // TbxPlayersName
            // 
            this.TbxPlayersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPlayersName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPlayersName.Location = new System.Drawing.Point(132, 64);
            this.TbxPlayersName.Name = "TbxPlayersName";
            this.TbxPlayersName.Size = new System.Drawing.Size(155, 29);
            this.TbxPlayersName.TabIndex = 4;
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            // 
            // CbxGame
            // 
            this.CbxGame.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(132, 106);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(155, 29);
            this.CbxGame.TabIndex = 5;
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Computer Score:";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerScore.Location = new System.Drawing.Point(302, 157);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(19, 21);
            this.LblPlayerScore.TabIndex = 8;
            this.LblPlayerScore.Text = "0";
            this.LblPlayerScore.Click += new System.EventHandler(this.LblPlayerScore_Click);
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputerScore.Location = new System.Drawing.Point(490, 157);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(19, 21);
            this.LblComputerScore.TabIndex = 10;
            this.LblComputerScore.Text = "0";
            this.LblComputerScore.Click += new System.EventHandler(this.LblComputerScore_Click);
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameName,
            this.PlayerScore,
            this.ComputerScore,
            this.Winner});
            this.LsvGameStatistics.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.HideSelection = false;
            this.LsvGameStatistics.Location = new System.Drawing.Point(6, 19);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Scrollable = false;
            this.LsvGameStatistics.Size = new System.Drawing.Size(539, 202);
            this.LsvGameStatistics.TabIndex = 11;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.View = System.Windows.Forms.View.Details;
            this.LsvGameStatistics.SelectedIndexChanged += new System.EventHandler(this.LsvGameStatistics_SelectedIndexChanged);
            // 
            // GameName
            // 
            this.GameName.Text = "Game";
            this.GameName.Width = 180;
            // 
            // PlayerScore
            // 
            this.PlayerScore.Text = "Player score";
            this.PlayerScore.Width = 100;
            // 
            // ComputerScore
            // 
            this.ComputerScore.Text = "Computer score";
            this.ComputerScore.Width = 135;
            // 
            // Winner
            // 
            this.Winner.Text = "Winner";
            this.Winner.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Game App";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LsvComputerHand);
            this.groupBox1.Controls.Add(this.LsvPlayerHand);
            this.groupBox1.Controls.Add(this.BtnStand);
            this.groupBox1.Controls.Add(this.BtnHit);
            this.groupBox1.Location = new System.Drawing.Point(15, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BlackJack";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Computer\'s hand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Player\'s hand";
            // 
            // LsvComputerHand
            // 
            this.LsvComputerHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.LsvComputerHand.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvComputerHand.GridLines = true;
            this.LsvComputerHand.HideSelection = false;
            this.LsvComputerHand.Location = new System.Drawing.Point(531, 36);
            this.LsvComputerHand.Name = "LsvComputerHand";
            this.LsvComputerHand.Size = new System.Drawing.Size(193, 154);
            this.LsvComputerHand.TabIndex = 3;
            this.LsvComputerHand.UseCompatibleStateImageBehavior = false;
            this.LsvComputerHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Face";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Suit";
            this.columnHeader3.Width = 100;
            // 
            // LsvPlayerHand
            // 
            this.LsvPlayerHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1});
            this.LsvPlayerHand.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvPlayerHand.GridLines = true;
            this.LsvPlayerHand.HideSelection = false;
            this.LsvPlayerHand.Location = new System.Drawing.Point(209, 36);
            this.LsvPlayerHand.Name = "LsvPlayerHand";
            this.LsvPlayerHand.Size = new System.Drawing.Size(205, 154);
            this.LsvPlayerHand.TabIndex = 2;
            this.LsvPlayerHand.UseCompatibleStateImageBehavior = false;
            this.LsvPlayerHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Face";
            this.columnHeader0.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Suit";
            this.columnHeader1.Width = 100;
            // 
            // BtnStand
            // 
            this.BtnStand.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStand.Location = new System.Drawing.Point(24, 135);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(97, 36);
            this.BtnStand.TabIndex = 1;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = true;
            this.BtnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // BtnHit
            // 
            this.BtnHit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHit.Location = new System.Drawing.Point(24, 49);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(97, 36);
            this.BtnHit.TabIndex = 0;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LsvGameStatistics);
            this.groupBox2.Controls.Add(this.BtnFindOverallWinner);
            this.groupBox2.Location = new System.Drawing.Point(12, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 230);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Game App made by Jayden Herron-Priestley 2024";
            // 
            // FormGameApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 650);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblComputerScore);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.TbxPlayersName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlayGame);
            this.Name = "FormGameApp";
            this.Text = "Game App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlayGame;
        private System.Windows.Forms.Button BtnFindOverallWinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxPlayersName;
        private System.Windows.Forms.ComboBox CbxGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label LblComputerScore;
        private System.Windows.Forms.ListView LsvGameStatistics;
        private System.Windows.Forms.ColumnHeader GameName;
        private System.Windows.Forms.ColumnHeader PlayerScore;
        private System.Windows.Forms.ColumnHeader ComputerScore;
        private System.Windows.Forms.ColumnHeader Winner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LsvComputerHand;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView LsvPlayerHand;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button BtnStand;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
    }
}

