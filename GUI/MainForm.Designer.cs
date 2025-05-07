//namespace FlappyBirdWinForms
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flappybird
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer gameTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            bird = new PictureBox();
            pipeBottom = new PictureBox();
            pictureBox1 = new PictureBox();
            labelStart = new Label();
            panelEndgame = new Panel();
            labelTotalScore = new Label();
            labelHighestScore = new Label();
            btnExit = new Button();
            btnRestart = new Button();
            scoreText = new Label();
            picBoxEndgame = new PictureBox();
            label1 = new Label();
            name = new Label();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEndgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEndgame).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.bird1;
            bird.Location = new Point(157, 185);
            bird.Name = "bird";
            bird.Size = new Size(40, 40);
            bird.TabIndex = 3;
            bird.TabStop = false;
            bird.Visible = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.Transparent;
            pipeBottom.Image = Properties.Resources.pipeBottom;
            pipeBottom.Location = new Point(539, 262);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(60, 200);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 4;
            pipeBottom.TabStop = false;
            pipeBottom.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pipeTop;
            pictureBox1.Location = new Point(539, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.BackColor = Color.Transparent;
            labelStart.Font = new System.Drawing.Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStart.ForeColor = Color.OrangeRed;
            labelStart.Location = new Point(273, 185);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(214, 50);
            labelStart.TabIndex = 13;
            labelStart.Text = "Tap to start ";
            // 
            // panelEndgame
            // 
            panelEndgame.BackColor = Color.Moccasin;
            panelEndgame.Controls.Add(labelTotalScore);
            panelEndgame.Controls.Add(labelHighestScore);
            panelEndgame.Controls.Add(btnExit);
            panelEndgame.Controls.Add(btnRestart);
            panelEndgame.Location = new Point(234, 238);
            panelEndgame.Name = "panelEndgame";
            panelEndgame.Size = new Size(454, 149);
            panelEndgame.TabIndex = 14;
            panelEndgame.Visible = false;
            // 
            // labelTotalScore
            // 
            labelTotalScore.AutoSize = true;
            labelTotalScore.BackColor = Color.Transparent;
            labelTotalScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalScore.ForeColor = Color.OrangeRed;
            labelTotalScore.Location = new Point(195, 22);
            labelTotalScore.Name = "labelTotalScore";
            labelTotalScore.Size = new Size(119, 40);
            labelTotalScore.TabIndex = 19;
            labelTotalScore.Text = "Score : ";
            // 
            // labelHighestScore
            // 
            labelHighestScore.AutoSize = true;
            labelHighestScore.BackColor = Color.Transparent;
            labelHighestScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHighestScore.ForeColor = Color.OrangeRed;
            labelHighestScore.Location = new Point(195, 86);
            labelHighestScore.Name = "labelHighestScore";
            labelHighestScore.Size = new Size(139, 40);
            labelHighestScore.TabIndex = 16;
            labelHighestScore.Text = "Record : ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Tomato;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Snow;
            btnExit.Location = new Point(37, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 40);
            btnExit.TabIndex = 13;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Tomato;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.Snow;
            btnRestart.Location = new Point(37, 88);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(126, 40);
            btnRestart.TabIndex = 14;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new System.Drawing.Font("Segoe UI Variable Display", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.ForeColor = Color.Tomato;
            scoreText.Location = new Point(370, 34);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(54, 63);
            scoreText.TabIndex = 17;
            scoreText.Text = "0";
            // 
            // picBoxEndgame
            // 
            picBoxEndgame.BackColor = Color.Transparent;
            picBoxEndgame.Image = Properties.Resources.game_over1;
            picBoxEndgame.Location = new Point(255, 142);
            picBoxEndgame.Name = "picBoxEndgame";
            picBoxEndgame.Size = new Size(411, 83);
            picBoxEndgame.TabIndex = 15;
            picBoxEndgame.TabStop = false;
            picBoxEndgame.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(327, 66);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 18;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new System.Drawing.Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.Tomato;
            name.Location = new Point(12, 9);
            name.Name = "name";
            name.Size = new Size(124, 40);
            name.TabIndex = 19;
            name.Text = "Player: ";
            // 
            // Main
            // 
            BackColor = Color.SkyBlue;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(name);
            Controls.Add(scoreText);
            Controls.Add(label1);
            Controls.Add(picBoxEndgame);
            Controls.Add(panelEndgame);
            Controls.Add(labelStart);
            Controls.Add(pictureBox1);
            Controls.Add(pipeBottom);
            Controls.Add(bird);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Flappy Bird";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEndgame.ResumeLayout(false);
            panelEndgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEndgame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox bird;
        private PictureBox pipeBottom;
        private PictureBox pictureBox1;
        private Label labelStart;
        private Panel panelEndgame;
        private PictureBox picBoxEndgame;
        private Button btnExit;
        private Button btnRestart;
        private Label labelHighestScore;
        private Label scoreText;
        private Label label1;
        private Label labelTotalScore;
        private Label name;
    }
}
