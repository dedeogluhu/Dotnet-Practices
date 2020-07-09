namespace OOPPrototype_Football
{
    partial class Form1
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
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnSpeciality = new System.Windows.Forms.Button();
            this.lbxPlayers = new System.Windows.Forms.ListBox();
            this.lbxTeams = new System.Windows.Forms.ListBox();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.lbxEnemyTeam = new System.Windows.Forms.ListBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTeamName = new System.Windows.Forms.TextBox();
            this.tbxStadName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxPlayersToAdd = new System.Windows.Forms.ListBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddPlayerFromList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(460, 305);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(131, 60);
            this.btnShoot.TabIndex = 0;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(597, 305);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(131, 60);
            this.btnPass.TabIndex = 1;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnSpeciality
            // 
            this.btnSpeciality.Location = new System.Drawing.Point(734, 305);
            this.btnSpeciality.Name = "btnSpeciality";
            this.btnSpeciality.Size = new System.Drawing.Size(131, 60);
            this.btnSpeciality.TabIndex = 2;
            this.btnSpeciality.Text = "Special Move";
            this.btnSpeciality.UseVisualStyleBackColor = true;
            this.btnSpeciality.Click += new System.EventHandler(this.btnSpeciality_Click);
            // 
            // lbxPlayers
            // 
            this.lbxPlayers.FormattingEnabled = true;
            this.lbxPlayers.ItemHeight = 16;
            this.lbxPlayers.Location = new System.Drawing.Point(460, 23);
            this.lbxPlayers.Name = "lbxPlayers";
            this.lbxPlayers.Size = new System.Drawing.Size(709, 276);
            this.lbxPlayers.TabIndex = 3;
            this.lbxPlayers.SelectedIndexChanged += new System.EventHandler(this.lbxPlayers_SelectedIndexChanged);
            // 
            // lbxTeams
            // 
            this.lbxTeams.FormattingEnabled = true;
            this.lbxTeams.ItemHeight = 16;
            this.lbxTeams.Location = new System.Drawing.Point(460, 371);
            this.lbxTeams.Name = "lbxTeams";
            this.lbxTeams.Size = new System.Drawing.Size(347, 276);
            this.lbxTeams.TabIndex = 4;
            this.lbxTeams.SelectedIndexChanged += new System.EventHandler(this.lbxTeams_SelectedIndexChanged);
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(88, 108);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(287, 22);
            this.tbxPlayerName.TabIndex = 5;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(88, 62);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(93, 17);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(154, 204);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(134, 50);
            this.btnAddPlayer.TabIndex = 7;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(88, 159);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(287, 24);
            this.cbxPosition.TabIndex = 8;
            // 
            // lbxEnemyTeam
            // 
            this.lbxEnemyTeam.FormattingEnabled = true;
            this.lbxEnemyTeam.ItemHeight = 16;
            this.lbxEnemyTeam.Location = new System.Drawing.Point(813, 371);
            this.lbxEnemyTeam.Name = "lbxEnemyTeam";
            this.lbxEnemyTeam.Size = new System.Drawing.Size(356, 276);
            this.lbxEnemyTeam.TabIndex = 9;
            this.lbxEnemyTeam.SelectedIndexChanged += new System.EventHandler(this.lbxEnemyTeam_SelectedIndexChanged);
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(1038, 305);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(131, 60);
            this.btnMatch.TabIndex = 10;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Team Name:";
            // 
            // tbxTeamName
            // 
            this.tbxTeamName.Location = new System.Drawing.Point(85, 319);
            this.tbxTeamName.Name = "tbxTeamName";
            this.tbxTeamName.Size = new System.Drawing.Size(287, 22);
            this.tbxTeamName.TabIndex = 12;
            // 
            // tbxStadName
            // 
            this.tbxStadName.Location = new System.Drawing.Point(85, 400);
            this.tbxStadName.Name = "tbxStadName";
            this.tbxStadName.Size = new System.Drawing.Size(287, 22);
            this.tbxStadName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stad Name:";
            // 
            // lbxPlayersToAdd
            // 
            this.lbxPlayersToAdd.FormattingEnabled = true;
            this.lbxPlayersToAdd.ItemHeight = 16;
            this.lbxPlayersToAdd.Location = new System.Drawing.Point(12, 451);
            this.lbxPlayersToAdd.Name = "lbxPlayersToAdd";
            this.lbxPlayersToAdd.Size = new System.Drawing.Size(287, 116);
            this.lbxPlayersToAdd.TabIndex = 15;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(154, 597);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(134, 50);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddPlayerFromList
            // 
            this.btnAddPlayerFromList.Location = new System.Drawing.Point(305, 471);
            this.btnAddPlayerFromList.Name = "btnAddPlayerFromList";
            this.btnAddPlayerFromList.Size = new System.Drawing.Size(131, 60);
            this.btnAddPlayerFromList.TabIndex = 17;
            this.btnAddPlayerFromList.Text = "Add From Players List";
            this.btnAddPlayerFromList.UseVisualStyleBackColor = true;
            this.btnAddPlayerFromList.Click += new System.EventHandler(this.btnAddPlayerFromList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 668);
            this.Controls.Add(this.btnAddPlayerFromList);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lbxPlayersToAdd);
            this.Controls.Add(this.tbxStadName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lbxEnemyTeam);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.lbxTeams);
            this.Controls.Add(this.lbxPlayers);
            this.Controls.Add(this.btnSpeciality);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnShoot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnSpeciality;
        private System.Windows.Forms.ListBox lbxPlayers;
        private System.Windows.Forms.ListBox lbxTeams;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.ListBox lbxEnemyTeam;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTeamName;
        private System.Windows.Forms.TextBox tbxStadName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxPlayersToAdd;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddPlayerFromList;
    }
}

