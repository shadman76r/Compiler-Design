using Microsoft.Data.SqlClient;
using System.Data;

namespace FeedbackSystem
{
    public class FeedbackManager
    {
        private string connectionString = "Server=SHADMAN\\SQLEXPRESS;Database=MetroServiceDB;Integrated Security=True;TrustServerCertificate=True";

        public void SaveFeedback(Feedback feedback)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Feedback (UserId, StationLocation, FeedbackMessage, Rating, FeedbackTime, Email) VALUES (@userId, @station, @message, @rating, @time, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", feedback.UserId);
                    cmd.Parameters.AddWithValue("@station", feedback.StationLocation);
                    cmd.Parameters.AddWithValue("@message", feedback.FeedbackMessage);
                    cmd.Parameters.AddWithValue("@rating", feedback.Rating);
                    cmd.Parameters.AddWithValue("@time", feedback.FeedbackTime);
                    cmd.Parameters.AddWithValue("@Email", feedback.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllFeedback()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Feedback";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}

