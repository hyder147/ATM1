namespace ATM1
{
    partial class Account
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
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            AccNumTb = new TextBox();
            label4 = new Label();
            AccFnameTb = new TextBox();
            label3 = new Label();
            AccNameTb = new TextBox();
            label5 = new Label();
            AddressTb = new TextBox();
            label6 = new Label();
            PhoneTb = new TextBox();
            label7 = new Label();
            PinTb = new TextBox();
            label8 = new Label();
            LogoutBtn = new Button();
            LoginBtn = new Button();
            label10 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1187, 121);
            panel2.TabIndex = 5;
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
            // AccNumTb
            // 
            AccNumTb.Location = new Point(598, 158);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(379, 46);
            AccNumTb.TabIndex = 9;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(99, 142);
            label4.Name = "label4";
            label4.Size = new Size(436, 62);
            label4.TabIndex = 8;
            label4.Text = "Account Number:";
            label4.Click += label4_Click;
            // 
            // AccFnameTb
            // 
            AccFnameTb.Location = new Point(598, 304);
            AccFnameTb.Multiline = true;
            AccFnameTb.Name = "AccFnameTb";
            AccFnameTb.Size = new Size(379, 46);
            AccFnameTb.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(189, 274);
            label3.Name = "label3";
            label3.Size = new Size(346, 62);
            label3.TabIndex = 10;
            label3.Text = "Father Name:";
            // 
            // AccNameTb
            // 
            AccNameTb.Location = new Point(598, 228);
            AccNameTb.Multiline = true;
            AccNameTb.Name = "AccNameTb";
            AccNameTb.Size = new Size(379, 46);
            AccNameTb.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(357, 212);
            label5.Name = "label5";
            label5.Size = new Size(178, 62);
            label5.TabIndex = 12;
            label5.Text = "Name:";
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(598, 383);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(379, 129);
            AddressTb.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(304, 367);
            label6.Name = "label6";
            label6.Size = new Size(231, 62);
            label6.TabIndex = 14;
            label6.Text = "Address:";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(598, 529);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(379, 46);
            PhoneTb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.CadetBlue;
            label7.Location = new Point(266, 529);
            label7.Name = "label7";
            label7.Size = new Size(269, 62);
            label7.TabIndex = 16;
            label7.Text = "Phone-No:";
            // 
            // PinTb
            // 
            PinTb.Location = new Point(598, 621);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(379, 46);
            PinTb.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(397, 605);
            label8.Name = "label8";
            label8.Size = new Size(138, 62);
            label8.TabIndex = 18;
            label8.Text = "PIN:";
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Teal;
            LogoutBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = SystemColors.Control;
            LogoutBtn.Location = new Point(611, 742);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(113, 49);
            LogoutBtn.TabIndex = 23;
            LogoutBtn.Text = "Log-Out";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Teal;
            LoginBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.Control;
            LoginBtn.Location = new Point(391, 742);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(113, 49);
            LoginBtn.TabIndex = 22;
            LoginBtn.Text = "Submit";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(540, 757);
            label10.Name = "label10";
            label10.Size = new Size(31, 22);
            label10.TabIndex = 24;
            label10.Text = "Or";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 828);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 25);
            panel1.TabIndex = 25;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 853);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(LogoutBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PinTb);
            Controls.Add(label8);
            Controls.Add(PhoneTb);
            Controls.Add(label7);
            Controls.Add(AddressTb);
            Controls.Add(label6);
            Controls.Add(AccNameTb);
            Controls.Add(label5);
            Controls.Add(AccFnameTb);
            Controls.Add(label3);
            Controls.Add(AccNumTb);
            Controls.Add(label4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox AccNumTb;
        private Label label4;
        private TextBox AccFnameTb;
        private Label label3;
        private TextBox AccNameTb;
        private Label label5;
        private TextBox AddressTb;
        private Label label6;
        private TextBox PhoneTb;
        private Label label7;
        private TextBox PinTb;
        private Label label8;
        private Button LogoutBtn;
        private Button LoginBtn;
        private Label label10;
        private Panel panel1;
    }
}