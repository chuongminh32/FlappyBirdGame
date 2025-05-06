// Thư viện cơ bản trong C#
namespace Flappybird
{
    public partial class Main : Form
    {
        // ======== BIẾN CHIM ========
        float birdAngle = 0f;        // Góc quay của chim, mặc định là 0
        float maxAngle = 90f;        // Góc tối đa khi chim rơi xuống
        float minAngle = -25f;       // Góc khi chim nhảy lên (ngẩng đầu)

        int gravity = 1;             // Trọng lực, làm chim rơi xuống dần
        int jump = -12;              // Vận tốc nhảy lên khi click
        int velocityY = 0;           // Vận tốc rơi của chim theo trục Y
        int birdY;                   // Tọa độ Y hiện tại của chim

        // ======== BIẾN ỐNG ========
        int pipeX;                   // Tọa độ X của ống (di chuyển từ phải sang trái)
        int pipeWidth = 60;          // Chiều rộng của ống
        int pipeHeight;             // Chiều cao của ống trên
        int gap = 200;              // Khoảng cách giữa ống trên và dưới
        int pipeSpeed = 6;          // Tốc độ di chuyển ống
        int score = 0;              // Điểm số của người chơi

        int numPipes = 3;
        int[] pipeXs;
        int[] pipeHeights;
        bool[] pipeScored;

        // ======== BIẾN LƠ LỬNG BAN ĐẦU ========
        bool isGameStarted = false;  // Game đã bắt đầu chưa
        int floatingOffset = 2;      // Biên độ dao động của chim khi chưa chơi
        int floatingDir = 1;         // Hướng dao động (lên / xuống)
        int baseY;                   // Vị trí y ban đầu của chim (làm mốc dao động)

        // ======== BIẾN TÍNH ĐIỂM  ========
        bool scored = false;

     
        Random rand = new Random();  // Dùng để tạo chiều cao ngẫu nhiên cho ống

        // ======== KHỞI TẠO FORM ========
        public Main()
        {
            InitializeComponent();        // Khởi tạo các control từ Designer
            this.DoubleBuffered = true;   // Tránh nhấp nháy khi vẽ đồ họa
            this.FormClosing += Main_FormClosing; // Đăng ký sự kiện khi đóng form 

        }

        // ======== SỰ KIỆN KHI FORM LOAD ========
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background; // Nền của trò chơi
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Khởi tạo các ống khi Form Load
            pipeXs = new int[numPipes];
            pipeHeights = new int[numPipes];
            pipeScored = new bool[numPipes];

            for (int i = 0; i < numPipes; i++)
            {
                pipeXs[i] = this.Width + i * (this.Width / numPipes);
                pipeHeights[i] = rand.Next(100, this.Height - gap - 100);
                pipeScored[i] = false;
            }
                

            // Thiết lập thông số ban đầu
            birdY = bird.Top;
            baseY = bird.Top;
            pipeX = this.Width;   // Ống khởi tạo nằm ngoài màn hình bên phải
            pipeHeight = rand.Next(100, this.Height - gap - 100); // Chiều cao ngẫu nhiên
            velocityY = 0;

            gameTimer.Start();              // Bắt đầu timer
            this.MouseClick += Form1_MouseClick; // Gắn sự kiện click chuột
        }

        // ======== CLICK CHUỘT => CHIM BAY ========
        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (!isGameStarted)
            {
                // Bắt đầu chơi
                labelStart.Visible = false; // ẩn label thông báo
                isGameStarted = true;
                velocityY = jump;
                birdAngle = minAngle;
                return;
            }

            // Các lần click sau: chim nhảy lên
            velocityY = jump;
            birdAngle = minAngle;
        }

        // ======== VÒNG LẶP GAME ========
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Nếu chưa bắt đầu chơi => chim dao động lơ lửng
            if (!isGameStarted)
            {
                birdY += floatingOffset * floatingDir;

                if (birdY > baseY + 10 || birdY < baseY - 10)
                    floatingDir *= -1;

                bird.Top = birdY;
                this.Invalidate(); // Gọi OnPaint để vẽ lại
                return;
            }

            // Chim rơi theo trọng lực
            velocityY += gravity;
            birdY += velocityY;
            bird.Top = birdY;

            // Cập nhật ống
            for (int i = 0; i < numPipes; i++)
            {
                pipeXs[i] -= pipeSpeed;

                // Kiểm tra và cộng điểm
                if (!pipeScored[i] && bird.Left > pipeXs[i] + pipeWidth)
                {
                    score++;
                    pipeScored[i] = true;
                }

                // Reset ống ra lại bên phải
                if (pipeXs[i] < -pipeWidth)
                {
                    pipeXs[i] = this.Width;
                    pipeHeights[i] = rand.Next(100, this.Height - gap - 100);
                    pipeScored[i] = false;
                }
            }


            // Góc quay chim tăng dần khi rơi
            if (birdAngle < maxAngle)
                birdAngle += 2f;

            // Kiểm tra và tăng điểm 1 lần duy nhất:
            if (!scored && bird.Left > pipeX + pipeWidth)
            {
                score++;
                scored = true;
            }

            // Reset lại khi ống mới xuất hiện (khi pipeX về cuối màn hình):
            if (pipeX < -pipeWidth)
            {
                pipeX = this.Width;
                pipeHeight = rand.Next(100, this.Height - gap - 100);
                scored = false; // chuẩn bị cho ống tiếp theo
            }

            // ====== KIỂM TRA VA CHẠM ======
            // Nếu chim đụng ống hoặc chạm đất
            //if (birdRect.IntersectsWith(pipeTop) || birdRect.IntersectsWith(pipeBottom) ||
            //    bird.Bottom >= this.ClientSize.Height - 40)
            //{
            //    gameTimer.Stop();            // Dừng game
            //    panelEndgame.Visible = true; // Hiện panel endgame
            //    picBoxEndgame.Visible = true; // Hiện hình ảnh endgame
            //    labelTotalScore.Text = "Score : " + score; // Hiện điểm số cuối cùng

            //}
            for (int i = 0; i < numPipes; i++)
            {
                Rectangle birdRect = bird.Bounds;
                Rectangle pipeTop = new Rectangle(pipeXs[i], 0, pipeWidth, pipeHeights[i]);
                Rectangle pipeBottom = new Rectangle(pipeXs[i], pipeHeights[i] + gap - 65, pipeWidth, this.Height - pipeHeights[i] - gap);

                if (birdRect.IntersectsWith(pipeTop) || birdRect.IntersectsWith(pipeBottom) ||
                    bird.Bottom >= this.ClientSize.Height - 40)
                {
                    EndGame();
                    return;
                }
            }


            // Cập nhật điểm số
            scoreText.Text = "" + score;

            // Yêu cầu vẽ lại (gọi OnPaint)
            this.Invalidate();
        }

        // ====== HÀM ENDGAME ======

        private void EndGame()
        {
            gameTimer.Stop();
            panelEndgame.Visible = true;
            picBoxEndgame.Visible = true;
            labelTotalScore.Text = "Score : " + score;
        }


        // ======== VẼ LẠI MÀN HÌNH ========
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            for (int i = 0; i < numPipes; i++)
            {
                g.DrawImage(Properties.Resources.pipeUp, new Rectangle(pipeXs[i], 0, pipeWidth, pipeHeights[i]));

                int bottomY = pipeHeights[i] + gap;
            int bottomHeight = this.Height - bottomY;
                g.DrawImage(Properties.Resources.pipeDown, new Rectangle(pipeXs[i], bottomY - 80, pipeWidth, bottomHeight));
            }

            // Vẽ chim xoay theo birdAngle
            Bitmap birdImg = Properties.Resources.bird;
            Bitmap rotatedBird = RotateImage(birdImg, birdAngle);
            g.DrawImage(rotatedBird, bird.Left, bird.Top, bird.Width, bird.Height);
            rotatedBird.Dispose();
        }


        // ======== XOAY HÌNH ẢNH CHIM THEO GÓC ========
        private Bitmap RotateImage(Bitmap source, float angle)
        {
            Bitmap rotated = new Bitmap(source.Width + 30, source.Height + 30);
            rotated.MakeTransparent();

            using (Graphics g = Graphics.FromImage(rotated))
            {
                // Xoay quanh tâm ảnh
                g.TranslateTransform(source.Width / 2f, source.Height / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-source.Width / 2f, -source.Height / 2f);
                g.DrawImage(source, 0, 0);
            }

            return rotated;
        }

        // ======== HÀM RESET GAME ========
        private void RestartGame()
        {
            isGameStarted = false;
            labelStart.Visible = true; // bật label thông báo

            bird.Top = this.Height / 2;
            birdY = bird.Top;
            baseY = birdY;
            velocityY = 0;

            // Xóa hết các cột ống hiện tại và tạo mới
            for (int i = 0; i < numPipes; i++)
            {
                pipeXs[i] = this.Width + i * (this.Width / numPipes); // Đặt lại vị trí của các ống ngoài màn hình
                pipeHeights[i] = rand.Next(100, this.Height - gap - 100); // Chiều cao ngẫu nhiên của ống
                pipeScored[i] = false; // Đặt lại trạng thái tính điểm cho từng ống
            }

            score = 0;
            scoreText.Text = "0";

            birdAngle = 0f;
            gameTimer.Start();
        }

        // ======== SỰ KIỆN KHI NHẤN NÚT RESTART ========
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
            panelEndgame.Visible = false; // ẩn panel endgame
            picBoxEndgame.Visible = false; // ẩn hình ảnh endgame
        }


        // ======== SỰ KIỆN KHI NHẤN NÚT EXIT -> HOME ========
        private void btnExit_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //  Đóng toàn bộ app nếu người dùng nhấn X
        }
    }
}