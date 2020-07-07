using OOPPrototype_Basketball.Classes;
using OOPPrototype_Basketball.Enums;
using OOPPrototype_Basketball.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPPrototype_Basketball
{
    public partial class Form1 : Form
    {
        PointGuard _stephenCurry;
        ShootingGuard _klayThompshon;
        SmallForward _andrewWiggins;
        PowerForward _draymondGreen;
        Center _willieCauleyStein;
        Player _selected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _stephenCurry = new PointGuard { Name = "Stephen Curry", Age = 32 };
            _klayThompshon = new ShootingGuard { Name = "Klay Thompson", Age = 30 };
            _andrewWiggins = new SmallForward { Name = "Andrew Wiggins", Age = 25 };
            _draymondGreen = new PowerForward { Name = "Draymond Green", Age = 30 };
            _willieCauleyStein = new Center { Name = "Willie Cauley Stein", Age = 26 };
            _selected = new Player();

            Team gsw = new Team
            {
                Name = "Golden State Warriors",
                Players = new List<Player> { _stephenCurry, _klayThompshon, _andrewWiggins, _draymondGreen, _willieCauleyStein },
                Stadium = "Chase Center",
                WhichConference = Conference.West
            };

            TeamDal.Teams = new List<Team>();
            TeamDal.Teams.Add(gsw);

            foreach (var item in TeamDal.Teams)
            {
                Teams.Items.Add(item.Name);
            }

            Players.Items.Add(_stephenCurry);
            Players.Items.Add(_klayThompshon);
            Players.Items.Add(_andrewWiggins);
            Players.Items.Add(_draymondGreen);
            Players.Items.Add(_willieCauleyStein);
        }

                public void btnShoot_Click(object sender, EventArgs e)
                {
                    MessageBox.Show(_selected.Shoot());
                }

                public void btnLayup_Click(object sender, EventArgs e)
                {
                    MessageBox.Show(_selected.LayUp());
                }

                public void btnShootThree_Click(object sender, EventArgs e)
                {
                    if (_selected is IThreePointShooter)
                    {
                        IThreePointShooter a = (IThreePointShooter)_selected;
                        MessageBox.Show(a.ShootThreePoint());
                    }
                    else
                    {
                        MessageBox.Show($"{_selected.Name} Can't Shoot Threes");
                    }
                }

                public void btnDunk_Click(object sender, EventArgs e)
                {
                    if (_selected is IDunker)
                    {
                        IDunker a = (IDunker)_selected;
                        MessageBox.Show(a.Dunk());
                    }
                    else
                    {
                        MessageBox.Show($"{_selected.Name} Can't Dunk");
                    }
                }

                public void btnRebaund_Click(object sender, EventArgs e)
                {
                    if (_selected is IRebaunder)
                    {
                        IRebaunder a = (IRebaunder)_selected;
                        MessageBox.Show(a.Rebaund());
                    }
                    else
                    {
                        MessageBox.Show($"{_selected.Name} Can't Rebaund");
                    }
                }

                public void Players_SelectedIndexChanged(object sender, EventArgs e)
                {
                    _selected = (Player)Players.SelectedItem;     
                }
            }
        }
