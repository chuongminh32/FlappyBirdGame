namespace Flappybird
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += Home_FormClosing; // Đăng ký sự kiện khi đóng form 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Lưu tên người chơi vào GameSession
            PlayerRecord.PlayerName = txtPlayerName.Text;
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            RecordForm recordForm = new RecordForm();
            recordForm.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //  Đóng toàn bộ app nếu người dùng nhấn X
        }
    }
}
