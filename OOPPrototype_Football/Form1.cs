using OOPPrototype_Football.Classes;
using OOPPrototype_Football.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Football
{
    public partial class Form1 : Form
    {
        Player _currentPlayer;
        Team _currentTeam;
        Team _currentEnemyTeam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player muslera = new GoalKeeper { Name = "Fernando Muslera", BirthDate = DateTime.Now };
            Player sabri = new Defender { Name = "Sabri Sarıoğlu", BirthDate = DateTime.Now };
            Player emre = new MidFielder { Name = "Emre Belözoğlu", BirthDate = DateTime.Now };
            Player ronaldo = new Striker { Name = "Cristiano Ronaldo", BirthDate = DateTime.Now };

            List<Player> gsPlayers = new List<Player> { muslera, sabri };
            List<Player> fbPlayers = new List<Player> { emre, ronaldo };
            Team gs = new Team { Name = "Galatasaray", Players = gsPlayers, Stadium = "TT Arena" };
            Team fb = new Team { Name = "Fenerbahçe", Players = fbPlayers, Stadium = "Şükrü Saraçoğlu" };

            lbxEnemyTeam.Items.Add(gs);
            lbxEnemyTeam.Items.Add(fb);

            lbxTeams.Items.Add(gs);
            lbxTeams.Items.Add(fb);

            lbxPlayers.Items.Add(muslera);
            lbxPlayers.Items.Add(sabri);
            lbxPlayers.Items.Add(emre);
            lbxPlayers.Items.Add(ronaldo);

            cbxPosition.Items.Add("Goal Keeper");
            cbxPosition.Items.Add("Defender");
            cbxPosition.Items.Add("Midfielder");
            cbxPosition.Items.Add("Striker");

            _currentPlayer = (Player)lbxPlayers.Items[0];
            _currentTeam = (Team)lbxTeams.Items[0];
            _currentEnemyTeam = (Team)lbxEnemyTeam.Items[0];
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_currentPlayer.Shoot());
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_currentPlayer.Pass());
        }

        private void btnSpeciality_Click(object sender, EventArgs e)
        {
            if (_currentPlayer is IGoalKeeper)
            {
                IGoalKeeper gk = (IGoalKeeper)_currentPlayer;
                MessageBox.Show(gk.CatchBall());
            }
            else if (_currentPlayer is IDefense)
            {
                IDefense df = (IDefense)_currentPlayer;
                MessageBox.Show(df.Defend());
            }
            else if (_currentPlayer is IGameMaker)
            {
                IGameMaker gm = (IGameMaker)_currentPlayer;
                MessageBox.Show(gm.CreatePosition());
            }
            else if (_currentPlayer is IForward)
            {
                IForward fw = (IForward)_currentPlayer;
                MessageBox.Show(fw.PlayForward());
            }
        }

        private void lbxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPlayer = (Player)lbxPlayers.SelectedItem;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (cbxPosition.SelectedIndex == 0)
            {
                Player player = new GoalKeeper { Name = tbxPlayerName.Text, BirthDate = DateTime.Now };
                lbxPlayers.Items.Add(player);
            }
            else if (cbxPosition.SelectedIndex == 1)
            {
                Player player = new Defender { Name = tbxPlayerName.Text, BirthDate = DateTime.Now };
                lbxPlayers.Items.Add(player);
            }
            else if (cbxPosition.SelectedIndex == 2)
            {
                Player player = new MidFielder { Name = tbxPlayerName.Text, BirthDate = DateTime.Now };
                lbxPlayers.Items.Add(player);
            }
            else if (cbxPosition.SelectedIndex == 3)
            {
                Player player = new Striker { Name = tbxPlayerName.Text, BirthDate = DateTime.Now };
                lbxPlayers.Items.Add(player);
            }
        }

        private void lbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTeam = (Team)lbxTeams.SelectedItem;
        }

        private void lbxEnemyTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentEnemyTeam = (Team)lbxEnemyTeam.SelectedItem;
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_currentTeam.Play(_currentEnemyTeam));
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            List<Player> list = new List<Player>();

            foreach (var item in lbxPlayersToAdd.Items)
            {
                list.Add((Player)item);
            }

            Team team = new Team { Name = tbxTeamName.Text, Players = list, Stadium = tbxStadName.Text };

            lbxTeams.Items.Add(team);
            lbxEnemyTeam.Items.Add(team);
        }

        private void btnAddPlayerFromList_Click(object sender, EventArgs e)
        {
            lbxPlayersToAdd.Items.Add(lbxPlayers.SelectedItem);
        }
    }
}
