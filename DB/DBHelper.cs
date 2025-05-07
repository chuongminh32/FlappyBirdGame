using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappybird.DB
{
    class DBHelper
    {
        string connectionString = "Server=MINH-CHUONG;Database=FlappyBirdDB;Trusted_Connection=True;";


        // load dữ liệu vào DataGridView trong record form
        public void LoadScoresToGrid(DataGridView dgv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TOP 10 Username, Score, PlayDate FROM Scores ORDER BY Score DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        // Hàm lưu record của người chơi
        public void SavePlayerRecord(string playerName, int score)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Scores (Username, Score, PlayDate) VALUES (@PlayerName, @Score, @Date)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PlayerName", playerName);
                command.Parameters.AddWithValue("@Score", score);
                command.Parameters.AddWithValue("@Date", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Hàm lấy điểm cao nhất + gần nhất của người chơi
        public int GetBestScore(string playerName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Username, Score, PlayDate FROM Scores WHERE Username = @PlayerName ORDER BY Score DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlayerName", playerName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetInt32(1); // Score
                }
                else
                {
                    return 0; // Không tìm thấy record
                }
            }
        }

    }
}

