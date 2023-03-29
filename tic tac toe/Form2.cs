using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program version = 0.0.2
// File version = 0.0.2.01

namespace tic_tac_toe
{
    public partial class Form2 : Form
    {
        public Form2(char winner)
        {
            InitializeComponent();

            if (winner == 'X')
            {
                label2.Text = "Crosses";
                label2.ForeColor = Color.Crimson;
            }
            else if (winner == 'O')
            {
                label2.Text = "Noughts";
                label2.ForeColor = Color.MediumBlue;
            }
            else
            {
                label2.Text = "Draw";
                label2.Location = new Point(95, 35);
                label3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
