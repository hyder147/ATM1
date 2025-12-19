namespace ATM1
{
    partial class Deposit
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
            button1 = new Button();
            DepositAmtLbl = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
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
            button2.Location = new Point(571, 553);
            button2.Name = "button2";
            button2.Size = new Size(148, 73);
            button2.TabIndex = 34;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(258, 553);
            button1.Name = "button1";
            button1.Size = new Size(154, 73);
            button1.TabIndex = 33;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DepositAmtLbl
            // 
            DepositAmtLbl.Location = new Point(571, 407);
            DepositAmtLbl.Multiline = true;
            DepositAmtLbl.Name = "DepositAmtLbl";
            DepositAmtLbl.Size = new Size(343, 46);
            DepositAmtLbl.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(220, 420);
            label5.Name = "label5";
            label5.Size = new Size(0, 66);
            label5.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(40, 391);
            label4.Name = "label4";
            label4.Size = new Size(493, 62);
            label4.TabIndex = 28;
            label4.Text = "Enter Your Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Calibri", 31F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(258, 202);
            label3.Name = "label3";
            label3.Size = new Size(452, 76);
            label3.TabIndex = 26;
            label3.Text = "Deposit Amount";
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
            panel1.TabIndex = 27;
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
            label6.TabIndex = 35;
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
            label1.Location = new Point(333, 13);
            label1.Name = "label1";
            label1.Size = new Size(693, 67);
            label1.TabIndex = 25;
            label1.Text = "ATM Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 665);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 25);
            panel2.TabIndex = 35;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 690);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DepositAmtLbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox DepositAmtLbl;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label6;
        private Panel panel2;
    }
}