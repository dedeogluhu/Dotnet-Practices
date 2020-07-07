﻿using OOPPrototype_Basketball.Classes;
using OOPPrototype_Basketball.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Players.Items.Add($"{_stephenCurry.Name} - {_stephenCurry.Age} - {_stephenCurry.GetType().Name}");
            Players.Items.Add($"{_klayThompshon.Name} - {_klayThompshon.Age} - {_klayThompshon.GetType().Name}");
            Players.Items.Add($"{_andrewWiggins.Name} - {_andrewWiggins.Age} - {_andrewWiggins.GetType().Name}");
            Players.Items.Add($"{_draymondGreen.Name} - {_draymondGreen.Age} - {_draymondGreen.GetType().Name}");
            Players.Items.Add($"{_willieCauleyStein.Name} - {_willieCauleyStein.Age} - {_willieCauleyStein.GetType().Name}");
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_selected.Shoot());
        }

        private void btnLayup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_selected.LayUp());
        }

        private void btnShootThree_Click(object sender, EventArgs e)
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

        private void btnDunk_Click(object sender, EventArgs e)
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

        private void btnRebaund_Click(object sender, EventArgs e)
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

        private void Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Players.SelectedIndex)
            {
                case 0:
                    _selected = _stephenCurry;
                    break;
                case 1:
                    _selected = _klayThompshon;
                    break;
                case 2:
                    _selected = _andrewWiggins;
                    break;
                case 3:
                    _selected = _draymondGreen;
                    break;
                case 4:
                    _selected = _willieCauleyStein;
                    break;
                default:
                    break;
            }
        }
    }
}
