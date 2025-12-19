namespace ATM1
{
    partial class FastCash
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            button9 = new Button();
            button7 = new Button();
            button3 = new Button();
            label3 = new Label();
            BalanceLbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 130);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 139);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(954, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 62);
            label1.TabIndex = 3;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Times New Roman", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(119, 32);
            label2.Name = "label2";
            label2.Size = new Size(766, 73);
            label2.TabIndex = 2;
            label2.Text = "ATM Management System";
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(421, 597);
            button4.Name = "button4";
            button4.Size = new Size(200, 80);
            button4.TabIndex = 32;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 716);
            panel3.Name = "panel3";
            panel3.Size = new Size(1021, 39);
            panel3.TabIndex = 31;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(723, 468);
            button2.Name = "button2";
            button2.Size = new Size(200, 80);
            button2.TabIndex = 30;
            button2.Text = "1000$";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Teal;
            button9.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(158, 468);
            button9.Name = "button9";
            button9.Size = new Size(204, 80);
            button9.TabIndex = 28;
            button9.Text = "100$";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(723, 318);
            button7.Name = "button7";
            button7.Size = new Size(200, 80);
            button7.TabIndex = 26;
            button7.Text = "50$";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(158, 318);
            button3.Name = "button3";
            button3.Size = new Size(204, 80);
            button3.TabIndex = 25;
            button3.Text = "10$";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Trebuchet MS", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(368, 162);
            label3.Name = "label3";
            label3.Size = new Size(314, 81);
            label3.TabIndex = 4;
            label3.Text = "Fast Cash";
            // 
            // BalanceLbl
            // 
            BalanceLbl.AutoSize = true;
            BalanceLbl.BackColor = SystemColors.Control;
            BalanceLbl.Font = new Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceLbl.ForeColor = Color.Teal;
            BalanceLbl.Location = new Point(431, 334);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(200, 40);
            BalanceLbl.TabIndex = 33;
            BalanceLbl.Text = "Available Bal";
            // 
            // FastCash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 755);
            Controls.Add(BalanceLbl);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FastCash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FastCash";
            Load += FastCash_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button4;
        private Panel panel3;
        private Button button2;
        private Button button9;
        private Button button7;
        private Button button3;
        private Label label3;
        private Label BalanceLbl;
    }
}