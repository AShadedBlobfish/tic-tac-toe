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

// Program version = 0.1.1
// File version = 0.1.1.03

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        #region Main

        int turn = 0;   // Turn starts at 0 and increments every turn
        int x_wins = 0;
        int o_wins = 0;
        Point location1 = new Point(458, 70);   // Creates two objects of class Point which represent the location which the turn indicator needs to be in depending on whether it is an "X" or a "O"
        Point location2 = new Point(454, 70);
        List<Button> player_locations = new List<Button>();
        List<Button> ai_locations = new List<Button>();
        bool ai = false;
        bool hard_ai = true;

        // Sets the inital states of all objects in the window
        public Form1(string version)
        {
            InitializeComponent();
            
            // The Text attribute of the buttons is set to the same as their names in the designer for debugging, so this loop sets them all to be empty
            foreach (Button button in panel1.Controls)
            {
                button.Text = "";
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Segoe UI", 48F);
            }

            label2.Text = "X";
            label2.ForeColor = Color.Crimson;
            label2.Location = location1;
            lbl_version.Text = "Version: " + version;
        }

        // Function to determine whether a player has won
        private char win()
        {
            // Note - I hate this

            // Horizontal wins
            if (sq_top_left.Text == sq_top_mid.Text && sq_top_mid.Text == sq_top_right.Text && sq_top_left.Text != "")
            {
                return Convert.ToChar(sq_top_left.Text);
            }
            else if (sq_mid_left.Text == sq_mid.Text && sq_mid.Text == sq_mid_right.Text && sq_mid_left.Text != "")
            {
                return Convert.ToChar(sq_mid_left.Text);
            }
            else if (sq_bot_left.Text == sq_bot_mid.Text && sq_bot_mid.Text == sq_bot_right.Text && sq_bot_left.Text != "")
            {
                return Convert.ToChar(sq_bot_left.Text);
            }
            // Diagonal wins
            else if (sq_top_left.Text == sq_mid.Text && sq_mid.Text == sq_bot_right.Text && sq_top_left.Text != "")
            {
                return Convert.ToChar(sq_top_left.Text);
            }
            else if (sq_top_right.Text == sq_mid.Text && sq_mid.Text == sq_bot_left.Text && sq_top_right.Text != "")
            {
                return Convert.ToChar(sq_top_right.Text);
            }
            // Vertical wins
            else if (sq_top_left.Text == sq_mid_left.Text && sq_mid_left.Text == sq_bot_left.Text && sq_top_left.Text != "")
            {
                return Convert.ToChar(sq_top_left.Text);
            }
            else if (sq_top_mid.Text == sq_mid.Text && sq_mid.Text == sq_bot_mid.Text && sq_top_mid.Text != "")
            {
                return Convert.ToChar(sq_top_mid.Text);
            }
            else if (sq_top_right.Text == sq_mid_right.Text && sq_mid_right.Text == sq_bot_right.Text && sq_top_right.Text != "")
            {
                return Convert.ToChar(sq_top_right.Text);
            }
            // No wins
            else
            {
                return '0';
            }
        }

        private bool draw()
        {
            int squares_filled = 0;
            foreach (Button button in panel1.Controls)
            {
                if (button.Text != "")
                {
                    squares_filled++;
                }
            }
            if (squares_filled == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Function to determine and display which player owns a square and check if the game has ended
        private void sq_click(Button btn)
        {
            if (btn.Text == "")
            {
                if (turn % 2 == 0)
                {
                    turn++;
                    btn.ForeColor = Color.Crimson;
                    btn.Text = "X";
                    label2.Location = location2;
                    label2.ForeColor = Color.MediumBlue;
                    label2.Text = "O";
                    player_locations.Add(btn);
                }
                else if (!ai)
                {
                    turn++;
                    btn.ForeColor = Color.MediumBlue;
                    btn.Text = "O";
                    label2.Location = location1;
                    label2.ForeColor = Color.Crimson;
                    label2.Text = "X";
                }
            }

            char winner = win();

            if (winner != '0')
            {
                label2.Text = "";
                Form2 win_msg = new Form2(winner);
                win_msg.ShowDialog();

                // Resetting the game
                foreach (Button button in panel1.Controls)
                {
                    button.Text = "";
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI", 48F);
                }
                label2.Text = "X";
                label2.ForeColor = Color.Crimson;
                label2.Location = location1;
                if (winner == 'X')
                {
                    x_wins++;
                }
                else if (winner == 'O')
                {
                    o_wins++;
                }
                label6.Text = Convert.ToString(o_wins);
                label7.Text = Convert.ToString(x_wins);
                turn = 0;
            }
            else if (draw())
            {
                label2.Text = "";
                Form2 win_msg = new Form2('0');
                win_msg.ShowDialog();

                // Resetting the game
                foreach (Button button in panel1.Controls)
                {
                    button.Text = "";
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI", 48F);
                }
                label2.Text = "X";
                label2.ForeColor = Color.Crimson;
                label2.Location = location1;
                label6.Text = Convert.ToString(o_wins);
                label7.Text = Convert.ToString(x_wins);
                turn = 0;
            }
            if (ai)
            {
                turn++;
                Button ai_square = ai_move();
                System.Threading.Thread.Sleep(500);
                ai_square.ForeColor = Color.MediumBlue;
                ai_square.Text = "O";
                label2.Location = location1;
                label2.ForeColor = Color.Crimson;
                label2.Text = "X";
                ai_locations.Add(ai_square);
            }
        }

        #region Button click handlers
        // Everything here just executes the above function for each button when it is clicked

        private void sq_top_left_Click(object sender, EventArgs e) => sq_click(sq_top_left);

        private void sq_top_mid_Click(object sender, EventArgs e) => sq_click(sq_top_mid);

        private void sq_top_right_Click(object sender, EventArgs e) => sq_click(sq_top_right);

        private void sq_mid_left_Click(object sender, EventArgs e) => sq_click(sq_mid_left);

        private void sq_mid_Click(object sender, EventArgs e) => sq_click(sq_mid);

        private void sq_mid_right_Click(object sender, EventArgs e) => sq_click(sq_mid_right);

        private void sq_bot_left_Click(object sender, EventArgs e) => sq_click(sq_bot_left);

        private void sq_bot_mid_Click(object sender, EventArgs e) => sq_click(sq_bot_mid);

        private void sq_bot_right_Click(object sender, EventArgs e) => sq_click(sq_bot_right);
        #endregion

        // Reset wins button
        private void button1_Click(object sender, EventArgs e)
        {
            o_wins = 0;
            x_wins = 0;
            label6.Text = Convert.ToString(o_wins);
            label7.Text = Convert.ToString(x_wins);
        }
        #endregion
        #region AI
        private Button ai_move()
        {
            // Note - Wow I really hate this

            // Hard AI (Always Counters, Always goes for Wins)
            if (hard_ai)
            {
                /// Horizontal Counters ///
                // Right Side
                if (player_locations.Contains(sq_top_left) && player_locations.Contains(sq_top_mid) && !ai_locations.Contains(sq_top_right))
                {
                    return sq_top_right;
                }
                else if (player_locations.Contains(sq_mid_left) && player_locations.Contains(sq_mid) && !ai_locations.Contains(sq_mid_right))
                {
                    return sq_mid_right;
                }
                else if (player_locations.Contains(sq_bot_left) && player_locations.Contains(sq_bot_mid) && !ai_locations.Contains(sq_bot_right))
                {
                    return sq_bot_right;
                }
                // Left side
                else if (player_locations.Contains(sq_top_mid) && player_locations.Contains(sq_top_right) && !ai_locations.Contains(sq_top_left))
                {
                    return sq_top_left;
                }
                else if (player_locations.Contains(sq_mid) && player_locations.Contains(sq_mid_right) && !ai_locations.Contains(sq_mid_left))
                {
                    return sq_mid_left;
                }
                else if (player_locations.Contains(sq_bot_mid) && player_locations.Contains(sq_bot_right) && !ai_locations.Contains(sq_bot_left))
                {
                    return sq_bot_left;
                }
                /// Vertical Counters ///
                // Top
                else if (player_locations.Contains(sq_mid_left) && player_locations.Contains(sq_bot_left) && !ai_locations.Contains(sq_top_left))
                {
                    return sq_top_left;
                }
                else if (player_locations.Contains(sq_mid) && player_locations.Contains(sq_bot_mid) && !ai_locations.Contains(sq_top_mid))
                {
                    return sq_top_mid;
                }
                else if (player_locations.Contains(sq_mid_right) && player_locations.Contains(sq_bot_right) && !ai_locations.Contains(sq_top_right))
                {
                    return sq_top_right;
                }
                // Bottom
                else if (player_locations.Contains(sq_top_left) && player_locations.Contains(sq_mid_left) && !ai_locations.Contains(sq_bot_left))
                {
                    return sq_bot_left;
                }
                else if (player_locations.Contains(sq_top_mid) && player_locations.Contains(sq_mid) && !ai_locations.Contains(sq_bot_mid))
                {
                    return sq_bot_mid;
                }
                else if (player_locations.Contains(sq_top_right) && player_locations.Contains(sq_mid_right) && !ai_locations.Contains(sq_bot_right))
                {
                    return sq_bot_right;
                }
                /// Diagonal Counters ///
                else if (player_locations.Contains(sq_mid) && player_locations.Contains(sq_bot_right) && !ai_locations.Contains(sq_top_left))
                {
                    return sq_top_left;
                }
                else if (player_locations.Contains(sq_mid) && player_locations.Contains(sq_bot_left) && !ai_locations.Contains(sq_top_right))
                {
                    return sq_top_right;
                }
                else if (player_locations.Contains(sq_mid) && player_locations.Contains(sq_top_left) && !ai_locations.Contains(sq_bot_right))
                {
                    return sq_bot_right;
                }
                else if (player_locations.Contains(sq_mid) && player_locations.Contains(sq_top_right) && !ai_locations.Contains(sq_bot_left))
                {
                    return sq_bot_left;
                }
                /// Horizontal wins ///
                // Left
                else if (ai_locations.Contains(sq_top_mid) && ai_locations.Contains(sq_top_right) && !player_locations.Contains(sq_top_left))
                {
                    return sq_top_left;
                }
                else if (ai_locations.Contains(sq_mid) && ai_locations.Contains(sq_mid_right) && !player_locations.Contains(sq_mid_left))
                {
                    return sq_mid_left;
                }
                else if (ai_locations.Contains(sq_bot_mid) && ai_locations.Contains(sq_bot_right) && !player_locations.Contains(sq_bot_left))
                {
                    return sq_bot_left;
                }
                // Right
                else if (ai_locations.Contains(sq_top_left) && ai_locations.Contains(sq_top_mid) && !player_locations.Contains(sq_top_right))
                {
                    return sq_top_right;
                }
                else if (ai_locations.Contains(sq_mid_left) && ai_locations.Contains(sq_mid) && !player_locations.Contains(sq_mid_right))
                {
                    return sq_mid_right;
                }
                else if (ai_locations.Contains(sq_bot_mid) && ai_locations.Contains(sq_bot_left) && !player_locations.Contains(sq_bot_right))
                {
                    return sq_bot_right;
                }
                /// Vertical Wins ///
                // Top
                else if (ai_locations.Contains(sq_mid_left) && ai_locations.Contains(sq_bot_left) && !player_locations.Contains(sq_top_left))
                {
                    return sq_top_left;
                }
                else if (ai_locations.Contains(sq_mid) && ai_locations.Contains(sq_bot_mid) && !player_locations.Contains(sq_top_mid))
                {
                    return sq_top_mid;
                }
                else if (ai_locations.Contains(sq_mid_right) && ai_locations.Contains(sq_bot_right) && !player_locations.Contains(sq_top_right))
                {
                    return sq_top_right;
                }
                // Bottom
                else if (ai_locations.Contains(sq_top_left) && ai_locations.Contains(sq_mid_left) && !player_locations.Contains(sq_bot_left))
                {
                    return sq_bot_left;
                }
                else if (ai_locations.Contains(sq_top_mid) && ai_locations.Contains(sq_mid) && !player_locations.Contains(sq_bot_mid))
                {
                    return sq_bot_mid;
                }
                else if (ai_locations.Contains(sq_top_right) && ai_locations.Contains(sq_mid_right) && !player_locations.Contains(sq_bot_right))
                {
                    return sq_bot_right;
                }
                /// Diagonal Wins ///
                else if (ai_locations.Contains(sq_mid) && ai_locations.Contains(sq_top_left) && !player_locations.Contains(sq_bot_right))
                {
                    return sq_bot_right;
                }
                else if (ai_locations.Contains(sq_mid) && ai_locations.Contains(sq_top_right) && !player_locations.Contains(sq_bot_left))
                {
                    return sq_bot_left;
                }
                else if (ai_locations.Contains(sq_mid) && ai_locations.Contains(sq_bot_left) && !player_locations.Contains(sq_top_right))
                {
                    return sq_top_right;
                }
                else if (ai_locations.Contains(sq_mid) && ai_locations.Contains(sq_bot_right) && !player_locations.Contains(sq_top_left))
                {
                    return sq_top_left;
                }
                else
                {
                    // Todo
                    Random rnd = new Random();
                    int random = rnd.Next(1, 9);
                }
            }
            // Normal AI (Usually Counters, Usually goes for Wins)
            else
            {

            }
            // More AI Difficulties coming soon (maybe)
        }
        #endregion
    }
}
