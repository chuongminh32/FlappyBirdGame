namespace Flappybird
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            txtName = new Label();
            txtUsername = new TextBox();
            btnRecord = new Button();
            btnStart = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(160, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.OrangeRed;
            txtName.Location = new Point(194, 221);
            txtName.Name = "txtName";
            txtName.Size = new Size(107, 40);
            txtName.TabIndex = 12;
            txtName.Text = "Name:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(323, 234);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(279, 27);
            txtUsername.TabIndex = 13;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.Tomato;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecord.ForeColor = Color.Snow;
            btnRecord.Location = new Point(194, 291);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(126, 40);
            btnRecord.TabIndex = 11;
            btnRecord.Text = "RECORD";
            btnRecord.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Tomato;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Snow;
            btnStart.Location = new Point(356, 291);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(126, 40);
            btnStart.TabIndex = 12;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Tomato;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Snow;
            btnExit.Location = new Point(532, 291);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 40);
            btnExit.TabIndex = 14;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnRecord);
            Controls.Add(btnStart);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Form2";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtName;
        private TextBox txtUsername;
        private Button btnRecord;
        private Button btnStart;
        private Button btnExit;
    }
}