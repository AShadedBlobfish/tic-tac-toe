using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program version = 0.1.2.01
// File version = 0.1.1.00

namespace tic_tac_toe
{
    public partial class Form3 : Form
    {
        public bool ai;
        public bool hardai;
        public Form3()
        {
            InitializeComponent();

            label1.Hide();
            button4.Hide();
            button5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Show();
            button4.Show();
            button5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ai = false;
            hardai = false;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ai = true;
            hardai = false;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ai = true;
            hardai = true;
            Close();
        }
    }
}
