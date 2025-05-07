using Flappybird.DB;
using System.Data;
using System.Data.SqlClient;


namespace Flappybird
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
            this.FormClosing += RecordForm_FormClosing; // Đăng ký sự kiện khi đóng form 

        }

 
        private void RecordForm_Load(object sender, EventArgs e)
        {
            DBHelper dBHelper = new DBHelper();
            dBHelper.LoadScoresToGrid(dgvTopPlayer); // Tải dữ liệu vào DataGridView
        }

        private void RecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //  Đóng toàn bộ app nếu người dùng nhấn X
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
