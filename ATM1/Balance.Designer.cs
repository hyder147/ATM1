namespace ATM1
{
    partial class Balance
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            AccNumLbl = new Label();
            BalanceLbl = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 121);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(1077, 0);
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
            label2.Location = new Point(189, 22);
            label2.Name = "label2";
            label2.Size = new Size(766, 73);
            label2.TabIndex = 2;
            label2.Text = "ATM Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 707);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 25);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(146, 375);
            label4.Name = "label4";
            label4.Size = new Size(352, 62);
            label4.TabIndex = 9;
            label4.Text = "Your Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(146, 241);
            label3.Name = "label3";
            label3.Size = new Size(436, 62);
            label3.TabIndex = 10;
            label3.Text = "Account Number:";
            // 
            // AccNumLbl
            // 
            AccNumLbl.AutoSize = true;
            AccNumLbl.BackColor = SystemColors.Control;
            AccNumLbl.Font = new Font("Trebuchet MS", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumLbl.ForeColor = Color.DarkSlateGray;
            AccNumLbl.Location = new Point(588, 241);
            AccNumLbl.Name = "AccNumLbl";
            AccNumLbl.Size = new Size(240, 67);
            AccNumLbl.TabIndex = 11;
            AccNumLbl.Text = "Acc Num";
            // 
            // BalanceLbl
            // 
            BalanceLbl.AutoSize = true;
            BalanceLbl.BackColor = SystemColors.Control;
            BalanceLbl.Font = new Font("Trebuchet MS", 27F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BalanceLbl.ForeColor = Color.DarkSlateGray;
            BalanceLbl.Location = new Point(519, 375);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(290, 67);
            BalanceLbl.TabIndex = 12;
            BalanceLbl.Text = "Balance RS";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(442, 526);
            button1.Name = "button1";
            button1.Size = new Size(203, 80);
            button1.TabIndex = 13;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 732);
            Controls.Add(button1);
            Controls.Add(BalanceLbl);
            Controls.Add(AccNumLbl);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label AccNumLbl;
        private Label BalanceLbl;
        private Button button1;
    }
}