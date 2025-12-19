namespace ATM1
{
    partial class LoginForm
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
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            LoginBtnTb = new Button();
            SignupBtn = new Button();
            label7 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 29F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, -4);
            label1.Name = "label1";
            label1.Size = new Size(693, 67);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 139);
            panel1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.CadetBlue;
            label8.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(927, 1);
            label8.Name = "label8";
            label8.Size = new Size(67, 62);
            label8.TabIndex = 12;
            label8.Text = "X";
            label8.Click += label8_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Calibri", 31F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(388, 197);
            label3.Name = "label3";
            label3.Size = new Size(168, 76);
            label3.TabIndex = 3;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(16, 312);
            label4.Name = "label4";
            label4.Size = new Size(436, 62);
            label4.TabIndex = 4;
            label4.Text = "Account Number:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(325, 403);
            label5.Name = "label5";
            label5.Size = new Size(0, 66);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(314, 407);
            label6.Name = "label6";
            label6.Size = new Size(138, 62);
            label6.TabIndex = 6;
            label6.Text = "PIN:";
            label6.Click += label6_Click;
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(458, 328);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(379, 46);
            AccNumTb.TabIndex = 7;
            // 
            // PinTb
            // 
            PinTb.Location = new Point(458, 422);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(343, 47);
            PinTb.TabIndex = 8;
            // 
            // LoginBtnTb
            // 
            LoginBtnTb.BackColor = Color.Teal;
            LoginBtnTb.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtnTb.ForeColor = SystemColors.Control;
            LoginBtnTb.Location = new Point(296, 543);
            LoginBtnTb.Name = "LoginBtnTb";
            LoginBtnTb.Size = new Size(134, 60);
            LoginBtnTb.TabIndex = 9;
            LoginBtnTb.Text = "Login";
            LoginBtnTb.UseVisualStyleBackColor = false;
            LoginBtnTb.Click += LoginBtnTb_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.Teal;
            SignupBtn.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = SystemColors.Control;
            SignupBtn.Location = new Point(537, 543);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(141, 60);
            SignupBtn.TabIndex = 10;
            SignupBtn.Text = "Sign-up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(458, 569);
            label7.Name = "label7";
            label7.Size = new Size(31, 22);
            label7.TabIndex = 11;
            label7.Text = "Or";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 639);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 25);
            panel2.TabIndex = 12;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(38F, 73F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 664);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtnTb);
            Controls.Add(PinTb);
            Controls.Add(AccNumTb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(11, 9, 11, 9);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Button LoginBtnTb;
        private Button SignupBtn;
        private Label label7;
        private Label label8;
        private Panel panel2;
    }
}