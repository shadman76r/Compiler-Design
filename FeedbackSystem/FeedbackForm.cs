namespace FeedbackSystem
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
            LoadStationsAndRatings();
        }
        private void LoadStationsAndRatings()
        {
            // Populating cmbStation with the list of stations
            cmbStation.Items.Add("Uttara North");
            cmbStation.Items.Add("Uttara Center");
            cmbStation.Items.Add("Uttara South");
            cmbStation.Items.Add("Pallabi");
            cmbStation.Items.Add("Mirpur 11");
            cmbStation.Items.Add("Mirpur 10");
            cmbStation.Items.Add("Kazipara");
            cmbStation.Items.Add("Shewrapara");
            cmbStation.Items.Add("Agargaon");
            cmbStation.Items.Add("Bijoy Sarani");
            cmbStation.Items.Add("Farmgate");
            cmbStation.Items.Add("Karwan Bazar");
            cmbStation.Items.Add("Shahbagh");
            cmbStation.Items.Add("Dhaka University");
            cmbStation.Items.Add("Bangladesh Secretariat");
            cmbStation.Items.Add("Motijheel");
            cmbStation.Items.Add("Kamalapur");

            // Set default selection (Optional)
            cmbStation.SelectedIndex = 0;

            // Populating cmbRating with values 1-5
            for (int i = 1; i <= 5; i++)
            {
                cmbRating.Items.Add(i);
            }

            // Set default selection (Optional)
            cmbRating.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string feedbackText = txtFeedback.Text;
            string station = cmbStation.SelectedItem?.ToString() ?? "Default Station"; // Providing default value if null
            int rating = int.Parse(cmbRating.SelectedItem?.ToString() ?? "0"); // Providing default value if null
            string email = txtEmail.Text;

            // Assuming UserId is obtained from the logged-in user or passed from another part of the program
            int userId = 1; // Example UserId, adjust as needed

            // Create a Feedback object using the entered data
            Feedback feedback = new Feedback(userId, station, feedbackText, rating, email);

            // Create an instance of FeedbackManager and save the feedback
            FeedbackManager feedbackManager = new FeedbackManager();
            feedbackManager.SaveFeedback(feedback);

            // Optionally, clear the form or show a message to the user
            MessageBox.Show("Feedback Submitted!");
            txtFeedback.Clear();
            txtEmail.Clear();
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtFeedback.Text);
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cmbStation.SelectedItem.ToString());
        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cmbRating.SelectedItem.ToString());
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtEmail.Text);
        }

        private void dataGridViewFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dataGridViewFeedback.SelectedCells[0].Value.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

