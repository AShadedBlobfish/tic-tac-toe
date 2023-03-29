// Program version = 0.0.1

namespace tic_tac_toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sq_bot_right = new System.Windows.Forms.Button();
            this.sq_bot_mid = new System.Windows.Forms.Button();
            this.sq_bot_left = new System.Windows.Forms.Button();
            this.sq_mid_right = new System.Windows.Forms.Button();
            this.sq_mid = new System.Windows.Forms.Button();
            this.sq_mid_left = new System.Windows.Forms.Button();
            this.sq_top_right = new System.Windows.Forms.Button();
            this.sq_top_mid = new System.Windows.Forms.Button();
            this.sq_top_left = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.sq_bot_right);
            this.panel1.Controls.Add(this.sq_bot_mid);
            this.panel1.Controls.Add(this.sq_bot_left);
            this.panel1.Controls.Add(this.sq_mid_right);
            this.panel1.Controls.Add(this.sq_mid);
            this.panel1.Controls.Add(this.sq_mid_left);
            this.panel1.Controls.Add(this.sq_top_right);
            this.panel1.Controls.Add(this.sq_top_mid);
            this.panel1.Controls.Add(this.sq_top_left);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // sq_bot_right
            // 
            this.sq_bot_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_bot_right.ForeColor = System.Drawing.Color.Black;
            this.sq_bot_right.Location = new System.Drawing.Point(277, 277);
            this.sq_bot_right.Margin = new System.Windows.Forms.Padding(0);
            this.sq_bot_right.Name = "sq_bot_right";
            this.sq_bot_right.Size = new System.Drawing.Size(125, 125);
            this.sq_bot_right.TabIndex = 4;
            this.sq_bot_right.Text = "sq_bot_right";
            this.sq_bot_right.UseVisualStyleBackColor = false;
            this.sq_bot_right.Click += new System.EventHandler(this.sq_bot_right_Click);
            // 
            // sq_bot_mid
            // 
            this.sq_bot_mid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_bot_mid.ForeColor = System.Drawing.Color.Black;
            this.sq_bot_mid.Location = new System.Drawing.Point(138, 277);
            this.sq_bot_mid.Margin = new System.Windows.Forms.Padding(0);
            this.sq_bot_mid.Name = "sq_bot_mid";
            this.sq_bot_mid.Size = new System.Drawing.Size(125, 125);
            this.sq_bot_mid.TabIndex = 4;
            this.sq_bot_mid.Text = "sq_bot_mid";
            this.sq_bot_mid.UseVisualStyleBackColor = false;
            this.sq_bot_mid.Click += new System.EventHandler(this.sq_bot_mid_Click);
            // 
            // sq_bot_left
            // 
            this.sq_bot_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_bot_left.ForeColor = System.Drawing.Color.Black;
            this.sq_bot_left.Location = new System.Drawing.Point(-2, 277);
            this.sq_bot_left.Margin = new System.Windows.Forms.Padding(0);
            this.sq_bot_left.Name = "sq_bot_left";
            this.sq_bot_left.Size = new System.Drawing.Size(125, 125);
            this.sq_bot_left.TabIndex = 6;
            this.sq_bot_left.Text = "sq_bot_left";
            this.sq_bot_left.UseVisualStyleBackColor = false;
            this.sq_bot_left.Click += new System.EventHandler(this.sq_bot_left_Click);
            // 
            // sq_mid_right
            // 
            this.sq_mid_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_mid_right.ForeColor = System.Drawing.Color.Black;
            this.sq_mid_right.Location = new System.Drawing.Point(277, 138);
            this.sq_mid_right.Margin = new System.Windows.Forms.Padding(0);
            this.sq_mid_right.Name = "sq_mid_right";
            this.sq_mid_right.Size = new System.Drawing.Size(125, 125);
            this.sq_mid_right.TabIndex = 5;
            this.sq_mid_right.Text = "sq_mid_right";
            this.sq_mid_right.UseVisualStyleBackColor = false;
            this.sq_mid_right.Click += new System.EventHandler(this.sq_mid_right_Click);
            // 
            // sq_mid
            // 
            this.sq_mid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_mid.ForeColor = System.Drawing.Color.Black;
            this.sq_mid.Location = new System.Drawing.Point(138, 138);
            this.sq_mid.Margin = new System.Windows.Forms.Padding(0);
            this.sq_mid.Name = "sq_mid";
            this.sq_mid.Size = new System.Drawing.Size(125, 125);
            this.sq_mid.TabIndex = 4;
            this.sq_mid.Text = "sq_mid";
            this.sq_mid.UseVisualStyleBackColor = false;
            this.sq_mid.Click += new System.EventHandler(this.sq_mid_Click);
            // 
            // sq_mid_left
            // 
            this.sq_mid_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_mid_left.ForeColor = System.Drawing.Color.Black;
            this.sq_mid_left.Location = new System.Drawing.Point(-2, 138);
            this.sq_mid_left.Margin = new System.Windows.Forms.Padding(0);
            this.sq_mid_left.Name = "sq_mid_left";
            this.sq_mid_left.Size = new System.Drawing.Size(125, 125);
            this.sq_mid_left.TabIndex = 3;
            this.sq_mid_left.Text = "sq_mid_left";
            this.sq_mid_left.UseVisualStyleBackColor = false;
            this.sq_mid_left.Click += new System.EventHandler(this.sq_mid_left_Click);
            // 
            // sq_top_right
            // 
            this.sq_top_right.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_top_right.ForeColor = System.Drawing.Color.Black;
            this.sq_top_right.Location = new System.Drawing.Point(277, -2);
            this.sq_top_right.Margin = new System.Windows.Forms.Padding(0);
            this.sq_top_right.Name = "sq_top_right";
            this.sq_top_right.Size = new System.Drawing.Size(125, 125);
            this.sq_top_right.TabIndex = 2;
            this.sq_top_right.Text = "sq_top_right";
            this.sq_top_right.UseVisualStyleBackColor = false;
            this.sq_top_right.Click += new System.EventHandler(this.sq_top_right_Click);
            // 
            // sq_top_mid
            // 
            this.sq_top_mid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_top_mid.ForeColor = System.Drawing.Color.Black;
            this.sq_top_mid.Location = new System.Drawing.Point(138, -2);
            this.sq_top_mid.Margin = new System.Windows.Forms.Padding(0);
            this.sq_top_mid.Name = "sq_top_mid";
            this.sq_top_mid.Size = new System.Drawing.Size(125, 125);
            this.sq_top_mid.TabIndex = 1;
            this.sq_top_mid.Text = "sq_top_mid";
            this.sq_top_mid.UseVisualStyleBackColor = false;
            this.sq_top_mid.Click += new System.EventHandler(this.sq_top_mid_Click);
            // 
            // sq_top_left
            // 
            this.sq_top_left.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sq_top_left.ForeColor = System.Drawing.Color.Black;
            this.sq_top_left.Location = new System.Drawing.Point(-2, -2);
            this.sq_top_left.Margin = new System.Windows.Forms.Padding(0);
            this.sq_top_left.Name = "sq_top_left";
            this.sq_top_left.Size = new System.Drawing.Size(125, 125);
            this.sq_top_left.TabIndex = 0;
            this.sq_top_left.Text = "sq_top_left";
            this.sq_top_left.UseVisualStyleBackColor = false;
            this.sq_top_left.Click += new System.EventHandler(this.sq_top_left_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(458, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Noughts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Crosses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Courier New", 7F);
            this.lbl_version.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_version.Location = new System.Drawing.Point(444, 384);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(89, 12);
            this.lbl_version.TabIndex = 9;
            this.lbl_version.Text = "Version: x.x.x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 398);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sq_mid;
        private System.Windows.Forms.Button sq_mid_left;
        private System.Windows.Forms.Button sq_top_right;
        private System.Windows.Forms.Button sq_top_mid;
        private System.Windows.Forms.Button sq_top_left;
        private System.Windows.Forms.Button sq_bot_right;
        private System.Windows.Forms.Button sq_bot_mid;
        private System.Windows.Forms.Button sq_bot_left;
        private System.Windows.Forms.Button sq_mid_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_version;
    }
}

