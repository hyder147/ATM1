namespace ATM1
{
    partial class ChangePin
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
            Pin1Tb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            Pin2Tb = new TextBox();
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
            button2.Location = new Point(575, 630);
            button2.Name = "button2";
            button2.Size = new Size(148, 73);
            button2.TabIndex = 21;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(246, 630);
            button1.Name = "button1";
            button1.Size = new Size(154, 73);
            button1.TabIndex = 20;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pin1Tb
            // 
            Pin1Tb.Location = new Point(441, 326);
            Pin1Tb.Multiline = true;
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(343, 47);
            Pin1Tb.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(164, 311);
            label6.Name = "label6";
            label6.Size = new Size(253, 62);
            label6.TabIndex = 17;
            label6.Text = "New PIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(220, 408);
            label5.Name = "label5";
            label5.Size = new Size(0, 66);
            label5.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Calibri", 31F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(258, 190);
            label3.Name = "label3";
            label3.Size = new Size(454, 76);
            label3.TabIndex = 13;
            label3.Text = "Update Your PIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 139);
            panel1.TabIndex = 14;
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
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 29F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 1);
            label1.Name = "label1";
            label1.Size = new Size(693, 67);
            label1.TabIndex = 12;
            label1.Text = "ATM Management System";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(72, 421);
            label8.Name = "label8";
            label8.Size = new Size(345, 62);
            label8.TabIndex = 23;
            label8.Text = "Confirm PIN:";
            // 
            // Pin2Tb
            // 
            Pin2Tb.Location = new Point(441, 427);
            Pin2Tb.Multiline = true;
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(343, 47);
            Pin2Tb.TabIndex = 24;
            Pin2Tb.TextChanged += Pin2Tb_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 714);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 25);
            panel2.TabIndex = 25;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 739);
            Controls.Add(panel2);
            Controls.Add(Pin2Tb);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Pin1Tb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox Pin1Tb;
        private Label label6;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private TextBox Pin2Tb;
        private Label label7;
        private Panel panel2;
    }
}