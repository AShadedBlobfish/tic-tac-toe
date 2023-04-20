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

// Program version = 0.1.2.01
// File version = 0.1.2.04

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
            Form3 settings = new Form3();
            settings.ShowDialog();
            ai = settings.ai;
            hard_ai = settings.hardai;
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
                else if (!draw() && ai)
                {
                    int ai_sq = ai_move();
                    Button ai_square = IntToButton(ai_sq);
                    //System.Threading.Thread.Sleep(500);
                    ai_square.ForeColor = Color.MediumBlue;
                    ai_square.Text = "O";
                    label2.Location = location1;
                    label2.ForeColor = Color.Crimson;
                    label2.Text = "X";
                    turn++;
                }

                winner = win();

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
        private int ButtonToInt(Button btn)
        {
            if (btn == sq_top_left)
            {
                return 1;
            }
            else if (btn == sq_top_mid)
            {
                return 2;
            }
            else if (btn == sq_top_right)
            {
                return 3;
            }
            else if (btn == sq_mid_left)
            {
                return 4;
            }
            else if (btn == sq_mid)
            {
                return 5;
            }
            else if (btn == sq_mid_right)
            {
                return 6;
            }
            else if (btn == sq_bot_left)
            {
                return 7;
            }
            else if (btn == sq_bot_mid)
            {
                return 8;
            }
            else if (btn == sq_bot_right)
            {
                return 9;
            }
            else
            {
                throw new Exception("Fatal Error");
            }
        }

        private Button IntToButton(int inni)
        {
            switch (inni)
            {
                case 1:
                    return sq_top_left;
                case 2:
                    return sq_top_mid;
                case 3:
                    return sq_top_right;
                case 4:
                    return sq_mid_left;
                case 5:
                    return sq_mid;
                case 6:
                    return sq_mid_right;
                case 7:
                    return sq_bot_left;
                case 8:
                    return sq_bot_mid;
                case 9:
                    return sq_bot_right;
                default:
                    throw new Exception("A Fatal Error Occured");
            }
        }
        private int ai_move()
        {
            // Note - Wow I *really* hate this

            int[] p_grid = new int[9];
            int i = 0;
            foreach (Button btn in panel1.Controls)
            {
                if (btn.Text == "X")
                {
                    p_grid[i] = 1;
                }
                else
                {
                    p_grid[i] = 0;
                }
                i++;
            }

            int[] ai_grid = new int[9];
            int j = 0;
            foreach (Button btn in panel1.Controls)
            {
                if (btn.Text == "O")
                {
                    ai_grid[j] = 1;
                }
                else
                {
                    ai_grid[j] = 0;
                }
                j++;
            }

            // Hard AI: Always Counters, Always goes for Wins
            if (hard_ai)
            {
                int[] working = new int[3];
                int[] working1 = new int[3];
                int pos0;

                /// Horizontal Wins ///
                // Top row
                Array.Copy(ai_grid, 0, working, 0, 3);
                Array.Copy(p_grid, 0, working1, 0, 3);
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        return pos0 + 1;
                    }
                }
                // Middle row
                Array.Copy(ai_grid, 3, working, 0, 3);
                Array.Copy(p_grid, 3, working1, 0, 3);
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        return pos0 + 4;
                    }
                }
                // Bottom row
                Array.Copy(ai_grid, 6, working, 0, 3);
                Array.Copy(p_grid, 6, working1, 0, 3);
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        return pos0 + 7;
                    }
                }
                /// Vertical Wins ///
                // Left
                working = new int[] { ai_grid[0], ai_grid[3], ai_grid[6] };
                working1 = new int[] { p_grid[0], p_grid[3], p_grid[6] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 4;
                            case 2:
                                return 7;
                        }
                    }
                }
                // Middle
                working = new int[] { ai_grid[1], ai_grid[4], ai_grid[7] };
                working1 = new int[] { p_grid[1], p_grid[4], p_grid[7] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 2;
                            case 1:
                                return 5;
                            case 2:
                                return 8;
                        }
                    }
                }
                // Right
                working = new int[] { ai_grid[2], ai_grid[6], ai_grid[8] };
                working1 = new int[] { p_grid[2], p_grid[6], p_grid[8] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 6;
                            case 2:
                                return 9;
                        }
                    }
                }
                /// Diagonal Wins ///
                working = new int[] { ai_grid[0], ai_grid[4], ai_grid[8] };
                working1 = new int[] { p_grid[0], p_grid[4], p_grid[8] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 5;
                            case 2:
                                return 9;
                        }
                    }
                }
                working = new int[] { ai_grid[2], ai_grid[4], ai_grid[6] };
                working1 = new int[] { p_grid[2], p_grid[4], p_grid[6] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 5;
                            case 2:
                                return 7;
                        }
                    }
                }
                /// Horizontal Counters ///
                // Top
                Array.Copy(p_grid, 0, working, 0, 3);
                Array.Copy(ai_grid, 0, working1, 0, 3);
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 2;
                            case 2:
                                return 3;       
                        }
                    }
                }
                // Middle
                Array.Copy(p_grid, 3, working, 0, 3);
                Array.Copy(ai_grid, 3, working1, 0, 3);
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 4;
                            case 1:
                                return 5;
                            case 2:
                                return 6;
                        }
                    }
                }
                // Bottom
                Array.Copy(p_grid, 6, working, 0, 3);
                Array.Copy(ai_grid, 6, working1, 0, 3);
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 7;
                            case 1:
                                return 8;
                            case 2:
                                return 9;
                        }
                    }
                }
                /// Vertical Counters ///
                // Left
                working = new int[] { p_grid[0], p_grid[3], p_grid[6] };
                working1 = new int[] { ai_grid[0], ai_grid[3], ai_grid[6] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 4;
                            case 2:
                                return 7;
                        }
                    }
                }
                // Middle
                working = new int[] { p_grid[1], p_grid[4], p_grid[7] };
                working1 = new int[] { ai_grid[1], ai_grid[4], ai_grid[7] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 2;
                            case 1:
                                return 5;
                            case 2:
                                return 8;
                        }
                    }
                }
                // Right
                working = new int[] { p_grid[2], p_grid[5], p_grid[8] };
                working1 = new int[] { ai_grid[2], ai_grid[5], ai_grid[8] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 6;
                            case 2:
                                return 9;
                        }
                    }
                }
                /// Diagonal Counters ///
                working = new int[] { p_grid[0], p_grid[4], p_grid[8] };
                working1 = new int[] { ai_grid[0], ai_grid[4], ai_grid[8] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 5;
                            case 2:
                                return 9;
                        }
                    }
                }
                working = new int[] { p_grid[2], p_grid[4], p_grid[6] };
                working1 = new int[] { ai_grid[2], ai_grid[4], ai_grid[6] };
                if (working.Sum() == 2)
                {
                    pos0 = Array.FindIndex(working, e => e == 0);
                    if (working1[pos0] == 0)
                    {
                        switch (pos0)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 5;
                            case 2:
                                return 7;
                        }
                    }
                }
                List<Button> empty = new List<Button>();
                foreach (Button btn in panel1.Controls)
                {
                    if (btn.Text == "")
                    {
                        empty.Add(btn);
                    }
                }
                int len_empty = empty.Count;
                Random rnd = new Random();
                int random = rnd.Next(0, len_empty);
                return ButtonToInt(empty[random]);
            }
            // Normal AI: Usually Counters, Usually goes for Wins
            else
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 5);
                if (random != 1)
                {
                    int[] working = new int[3];
                    int[] working1 = new int[3];
                    int pos0;

                    /// Horizontal Wins ///
                    // Top row
                    Array.Copy(ai_grid, 0, working, 0, 3);
                    Array.Copy(p_grid, 0, working1, 0, 3);
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            return pos0 + 1;
                        }
                    }
                    // Middle row
                    Array.Copy(ai_grid, 3, working, 0, 3);
                    Array.Copy(p_grid, 3, working1, 0, 3);
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            return pos0 + 4;
                        }
                    }
                    // Bottom row
                    Array.Copy(ai_grid, 6, working, 0, 3);
                    Array.Copy(p_grid, 6, working1, 0, 3);
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            return pos0 + 7;
                        }
                    }
                    /// Vertical Wins ///
                    // Left
                    working = new int[] { ai_grid[0], ai_grid[3], ai_grid[6] };
                    working1 = new int[] { p_grid[0], p_grid[3], p_grid[6] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 1;
                                case 1:
                                    return 4;
                                case 2:
                                    return 7;
                            }
                        }
                    }
                    // Middle
                    working = new int[] { ai_grid[1], ai_grid[4], ai_grid[7] };
                    working1 = new int[] { p_grid[1], p_grid[4], p_grid[7] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 2;
                                case 1:
                                    return 5;
                                case 2:
                                    return 8;
                            }
                        }
                    }
                    // Right
                    working = new int[] { ai_grid[2], ai_grid[6], ai_grid[8] };
                    working1 = new int[] { p_grid[2], p_grid[6], p_grid[8] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 3;
                                case 1:
                                    return 6;
                                case 2:
                                    return 9;
                            }
                        }
                    }
                    /// Diagonal Wins ///
                    working = new int[] { ai_grid[0], ai_grid[4], ai_grid[8] };
                    working1 = new int[] { p_grid[0], p_grid[4], p_grid[8] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 1;
                                case 1:
                                    return 5;
                                case 2:
                                    return 9;
                            }
                        }
                    }
                    working = new int[] { ai_grid[2], ai_grid[4], ai_grid[6] };
                    working1 = new int[] { p_grid[2], p_grid[4], p_grid[6] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 3;
                                case 1:
                                    return 5;
                                case 2:
                                    return 7;
                            }
                        }
                    }
                    /// Horizontal Counters ///
                    // Top
                    Array.Copy(p_grid, 0, working, 0, 3);
                    Array.Copy(ai_grid, 0, working1, 0, 3);
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 1;
                                case 1:
                                    return 2;
                                case 2:
                                    return 3;
                            }
                        }
                    }
                    // Middle
                    Array.Copy(p_grid, 3, working, 0, 3);
                    Array.Copy(ai_grid, 3, working1, 0, 3);
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 4;
                                case 1:
                                    return 5;
                                case 2:
                                    return 6;
                            }
                        }
                    }
                    // Bottom
                    Array.Copy(p_grid, 6, working, 0, 3);
                    Array.Copy(ai_grid, 6, working1, 0, 3);
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 7;
                                case 1:
                                    return 8;
                                case 2:
                                    return 9;
                            }
                        }
                    }
                    /// Vertical Counters ///
                    // Left
                    working = new int[] { p_grid[0], p_grid[3], p_grid[6] };
                    working1 = new int[] { ai_grid[0], ai_grid[3], ai_grid[6] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 1;
                                case 1:
                                    return 4;
                                case 2:
                                    return 7;
                            }
                        }
                    }
                    // Middle
                    working = new int[] { p_grid[1], p_grid[4], p_grid[7] };
                    working1 = new int[] { ai_grid[1], ai_grid[4], ai_grid[7] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 2;
                                case 1:
                                    return 5;
                                case 2:
                                    return 8;
                            }
                        }
                    }
                    // Right
                    working = new int[] { p_grid[2], p_grid[5], p_grid[8] };
                    working1 = new int[] { ai_grid[2], ai_grid[5], ai_grid[8] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 3;
                                case 1:
                                    return 6;
                                case 2:
                                    return 9;
                            }
                        }
                    }
                    /// Diagonal Counters ///
                    working = new int[] { p_grid[0], p_grid[4], p_grid[8] };
                    working1 = new int[] { ai_grid[0], ai_grid[4], ai_grid[8] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 1;
                                case 1:
                                    return 5;
                                case 2:
                                    return 9;
                            }
                        }
                    }
                    working = new int[] { p_grid[2], p_grid[4], p_grid[6] };
                    working1 = new int[] { ai_grid[2], ai_grid[4], ai_grid[6] };
                    if (working.Sum() == 2)
                    {
                        pos0 = Array.FindIndex(working, e => e == 0);
                        if (working1[pos0] == 0)
                        {
                            switch (pos0)
                            {
                                case 0:
                                    return 3;
                                case 1:
                                    return 5;
                                case 2:
                                    return 7;
                            }
                        }
                    }
                }
                List<Button> empty = new List<Button>();
                foreach (Button btn in panel1.Controls)
                {
                    if (btn.Text == "")
                    {
                        empty.Add(btn);
                    }
                }
                int len_empty = empty.Count;
                Random rnd1 = new Random();
                int random1 = rnd1.Next(0, len_empty);
                return ButtonToInt(empty[random1]);
            }
            // More AI Difficulties coming soon (maybe)
        }
        #endregion
    }
}
