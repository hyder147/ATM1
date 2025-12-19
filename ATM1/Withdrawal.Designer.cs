namespace ATM1
{
    partial class Withdrawal
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
            label2 = new Label();
            button2 = new Button();
            WithdrawalTb = new Button();
            WithdrawAmtTb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            BalanceLbl = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Times New Roman", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(113, 31);
            label2.Name = "label2";
            label2.Size = new Size(766, 73);
            label2.TabIndex = 2;
            label2.Text = "ATM Management System";
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(573, 529);
            button2.Name = "button2";
            button2.Size = new Size(148, 73);
            button2.TabIndex = 42;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // WithdrawalTb
            // 
            WithdrawalTb.BackColor = Color.Teal;
            WithdrawalTb.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WithdrawalTb.ForeColor = SystemColors.Control;
            WithdrawalTb.Location = new Point(243, 529);
            WithdrawalTb.Name = "WithdrawalTb";
            WithdrawalTb.Size = new Size(154, 73);
            WithdrawalTb.TabIndex = 41;
            WithdrawalTb.Text = "Withdrawal";
            WithdrawalTb.UseVisualStyleBackColor = false;
            WithdrawalTb.Click += button1_Click;
            // 
            // WithdrawAmtTb
            // 
            WithdrawAmtTb.Location = new Point(522, 413);
            WithdrawAmtTb.Multiline = true;
            WithdrawAmtTb.Name = "WithdrawAmtTb";
            WithdrawAmtTb.Size = new Size(343, 46);
            WithdrawAmtTb.TabIndex = 40;
            WithdrawAmtTb.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(107, 332);
            label5.Name = "label5";
            label5.Size = new Size(0, 66);
            label5.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(12, 398);
            label4.Name = "label4";
            label4.Size = new Size(493, 62);
            label4.TabIndex = 38;
            label4.Text = "Enter Your Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Calibri", 31F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(243, 170);
            label3.Name = "label3";
            label3.Size = new Size(556, 76);
            label3.TabIndex = 36;
            label3.Text = "Withdrawal Amount";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 139);
            panel1.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.CadetBlue;
            label6.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(910, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 62);
            label6.TabIndex = 43;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.CadetBlue;
            label7.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(975, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 62);
            label7.TabIndex = 25;
            label7.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 29F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, -75);
            label1.Name = "label1";
            label1.Size = new Size(693, 67);
            label1.TabIndex = 35;
            label1.Text = "ATM Management System";
            // 
            // BalanceLbl
            // 
            BalanceLbl.AutoSize = true;
            BalanceLbl.BackColor = SystemColors.Control;
            BalanceLbl.Font = new Font("Calibri Light", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceLbl.ForeColor = Color.Teal;
            BalanceLbl.Location = new Point(319, 292);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(402, 66);
            BalanceLbl.TabIndex = 43;
            BalanceLbl.Text = "Available Balance";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 639);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 25);
            panel2.TabIndex = 44;
            // 
            // Withdrawal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 664);
            Controls.Add(panel2);
            Controls.Add(BalanceLbl);
            Controls.Add(button2);
            Controls.Add(WithdrawalTb);
            Controls.Add(WithdrawAmtTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Withdrawal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdrawal";
            Load += Withdrawal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button WithdrawalTb;
        private TextBox WithdrawAmtTb;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label BalanceLbl;
        private Panel panel2;
    }
}