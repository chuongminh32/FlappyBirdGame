using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class Form1 : Form
    {
        // xoay đâù chim theo hướng bay 
        float birdAngle = 0f;           // góc quay của chim
        float maxAngle = 90f;           // góc xoay tối đa khi rơi
        float minAngle = -25f;          // góc xoay khi bay lên


        int gravity = 1;
        int jump = -12;
        int velocityY = 0;
        int birdY;

        int pipeX;
        int pipeWidth = 60;
        int pipeHeight;
        int gap = 200;
        int pipeSpeed = 6;
        int score = 0;



        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Giảm flicker khi vẽ pipe
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            birdY = bird.Top;
            pipeX = this.Width;
            pipeHeight = rand.Next(100, this.Height - gap - 100);
            velocityY = 0;

            gameTimer.Start();
            this.MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            birdAngle = minAngle;
            velocityY = jump; // reset vận tốc Y để chim bay lên
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // chim rơi
            velocityY += gravity;
            birdY += velocityY;
            bird.Top = birdY;

            // cột di chuyển
            pipeX -= pipeSpeed;


            // Góc xoay dần dần tăng về maxAngle
            if (birdAngle < maxAngle)
                birdAngle += 2f;

            // cột đi qua trái thì reset lại
            if (pipeX < -pipeWidth)
            {
                pipeX = this.Width;
                pipeHeight = rand.Next(100, this.Height - gap - 100);
                score++;
            }

            // kiểm tra va chạm
            Rectangle birdRect = bird.Bounds;
            Rectangle pipeTop = new Rectangle(pipeX, 0, pipeWidth, pipeHeight);
            Rectangle pipeBottom = new Rectangle(pipeX, pipeHeight + gap - 40 , pipeWidth, this.Height - pipeHeight - gap);

            if (birdRect.IntersectsWith(pipeTop) || birdRect.IntersectsWith(pipeBottom) ||
                bird.Bottom >= this.ClientSize.Height - 40)
            {
                gameTimer.Stop();
                btnRestart.Visible = true;
            }

            // cập nhật điểm và vẽ lại pipe
            scoreText.Text = "Score: " + score;
            this.Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Ống trên (hướng xuống)
            Image pipeTop = Properties.Resources.pipeUp;
            g.DrawImage(pipeTop, new Rectangle(pipeX, 0, pipeWidth, pipeHeight));

            // Ống dưới (hướng lên)
            Image pipeBottom = Properties.Resources.pipeDown;
            int bottomY = pipeHeight + gap;
            int bottomHeight = this.Height - bottomY;
            g.DrawImage(pipeBottom, new Rectangle(pipeX, bottomY - 80 , pipeWidth, bottomHeight));

            // Vẽ chim xoay
            Bitmap birdImg = Properties.Resources.bird;
            Bitmap rotatedBird = RotateImage(birdImg, birdAngle);
            g.DrawImage(rotatedBird, bird.Left, bird.Top, bird.Width, bird.Height);

            // Giải phóng tài nguyên
            rotatedBird.Dispose();
        }
        
        private Bitmap RotateImage(Bitmap source, float angle)
        {
            // Tạo ảnh mới với kích thước đủ lớn để chứa ảnh xoay
            Bitmap rotated = new Bitmap(source.Width + 30, source.Height + 30);
            rotated.MakeTransparent(); // đảm bảo nền trong suốt

            using (Graphics g = Graphics.FromImage(rotated))
            {
                // Di chuyển gốc tọa độ đến tâm ảnh
                g.TranslateTransform(source.Width / 2f, source.Height / 2f);
                // Xoay
                g.RotateTransform(angle);
                // Vẽ ảnh gốc, căn giữa
                g.TranslateTransform(-source.Width / 2f, -source.Height / 2f);
                g.DrawImage(source, 0, 0);
            }
            return rotated;
        }


        private void RestartGame()
        {
            bird.Top = this.Height / 2;
            birdY = bird.Top;
            velocityY = 0;

            pipeX = this.Width;
            pipeHeight = rand.Next(100, this.Height - gap - 100);
            score = 0;

            scoreText.Text = "Score: 0";

            birdAngle = 0f;
            gameTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
            btnRestart.Visible = false;
        }
    }
}
