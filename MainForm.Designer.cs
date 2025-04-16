//namespace FlappyBirdWinForms
namespace Flappybird
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreText = new Label();
            btnRestart = new Button();
            bird = new PictureBox();
            pipeBottom = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Arial", 18F, FontStyle.Bold);
            scoreText.ForeColor = Color.White;
            scoreText.Location = new Point(6, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(134, 35);
            scoreText.TabIndex = 0;
            scoreText.Text = "Score: 0";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Transparent;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.OrangeRed;
            btnRestart.Location = new Point(338, 218);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 40);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Visible = false;
            btnRestart.Click += button1_Click;
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.bird1;
            bird.Location = new Point(100, 100);
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
            // Form1
            // 
            BackColor = Color.SkyBlue;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox1);
            Controls.Add(pipeBottom);
            Controls.Add(bird);
            Controls.Add(btnRestart);
            Controls.Add(scoreText);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Flappy Bird";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnRestart;
        private PictureBox bird;
        private PictureBox pipeBottom;
        private PictureBox pictureBox1;
    }
}
