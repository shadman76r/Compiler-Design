namespace Feedbacksystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Collect feedback details
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string stationLocation = cmbStationLocation.SelectedItem.ToString();
            string feedbackMessage = txtFeedbackMessage.Text;
            int rating = (int)nudRating.Value;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(feedbackMessage))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display feedback summary
            MessageBox.Show($"User: {userName}\nEmail: {email}\nStation: {stationLocation}\nFeedback: {feedbackMessage}\nRating: {rating}",
                "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
