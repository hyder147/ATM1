namespace ATM1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Percentage = new Label();
            Myprogress = new HScrollBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(358, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Times New Roman", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(766, 73);
            label1.TabIndex = 1;
            label1.Text = "ATM Management System";
            label1.Click += label1_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percentage.Location = new Point(866, 568);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(85, 63);
            Percentage.TabIndex = 2;
            Percentage.Text = "%";
            Percentage.Click += label2_Click;
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(3, 631);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(948, 38);
            Myprogress.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(954, 671);
            Controls.Add(Myprogress);
            Controls.Add(Percentage);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label Percentage;
        private HScrollBar Myprogress;
        private System.Windows.Forms.Timer timer1;
    }
}
