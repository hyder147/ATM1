namespace ATM1
{
    partial class MiniStatements
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
            label3 = new Label();
            button4 = new Button();
            panel3 = new Panel();
            MiniStatementDGV = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).BeginInit();
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
            panel2.Size = new Size(1004, 139);
            panel2.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(932, 0);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Trebuchet MS", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(247, 157);
            label3.Name = "label3";
            label3.Size = new Size(515, 81);
            label3.TabIndex = 34;
            label3.Text = "Mini Statements";
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(398, 556);
            button4.Name = "button4";
            button4.Size = new Size(200, 80);
            button4.TabIndex = 36;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 660);
            panel3.Name = "panel3";
            panel3.Size = new Size(1004, 39);
            panel3.TabIndex = 35;
            // 
            // MiniStatementDGV
            // 
            MiniStatementDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MiniStatementDGV.BackgroundColor = Color.White;
            MiniStatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MiniStatementDGV.Location = new Point(0, 241);
            MiniStatementDGV.Name = "MiniStatementDGV";
            MiniStatementDGV.RowHeadersWidth = 62;
            MiniStatementDGV.Size = new Size(1004, 292);
            MiniStatementDGV.TabIndex = 37;
            // 
            // MiniStatements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 699);
            Controls.Add(MiniStatementDGV);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MiniStatements";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStatements";
            Load += MiniStatements_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniStatementDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Panel panel3;
        private DataGridView MiniStatementDGV;
    }
}