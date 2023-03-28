using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program version = 0.0.1-alpha
// File version = 0.0.1.04

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        int turn = 0;
        Point location1 = new Point(458, 70);
        Point location2 = new Point(454, 70);
        public Form1(string version)
        {
            InitializeComponent();
            
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI", 48F);
                }
            }

            label2.Text = "X";
            label2.ForeColor = Color.Crimson;
            label2.Location = location1;
        }

        private void sq_top_left_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_top_left.ForeColor = Color.Crimson;
                sq_top_left.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_top_left.ForeColor = Color.MediumBlue;
                sq_top_left.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_top_mid_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_top_mid.ForeColor = Color.Crimson;
                sq_top_mid.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_top_mid.ForeColor = Color.MediumBlue;
                sq_top_mid.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_top_right_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_top_right.ForeColor = Color.Crimson;
                sq_top_right.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_top_right.ForeColor = Color.MediumBlue;
                sq_top_right.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_mid_left_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_mid_left.ForeColor = Color.Crimson;
                sq_mid_left.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_mid_left.ForeColor = Color.MediumBlue;
                sq_mid_left.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_mid_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_mid.ForeColor = Color.Crimson;
                sq_mid.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_mid.ForeColor = Color.MediumBlue;
                sq_mid.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_mid_right_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_mid_right.ForeColor = Color.Crimson;
                sq_mid_right.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_mid_right.ForeColor = Color.MediumBlue;
                sq_mid_right.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_bot_left_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_bot_left.ForeColor = Color.Crimson;
                sq_bot_left.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_bot_left.ForeColor = Color.MediumBlue;
                sq_bot_left.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_bot_mid_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_bot_mid.ForeColor = Color.Crimson;
                sq_bot_mid.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_bot_mid.ForeColor = Color.MediumBlue;
                sq_bot_mid.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }

        private void sq_bot_right_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn % 2 != 0)
            {
                sq_bot_right.ForeColor = Color.Crimson;
                sq_bot_right.Text = "X";
                label2.Location = location2;
                label2.ForeColor = Color.MediumBlue;
                label2.Text = "O";
            }
            else
            {
                sq_bot_right.ForeColor = Color.MediumBlue;
                sq_bot_right.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
            }
        }
    }
}
