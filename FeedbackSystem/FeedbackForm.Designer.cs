using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FeedbackSystem
{
    public partial class FeedbackForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        // UI Elements
        private Label lblTitle;
        private TextBox txtFeedback;
        private Label lblStation;
        private ComboBox cmbStation;
        private Label lblRating;
        private ComboBox cmbRating;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSubmit;
        private DataGridView dataGridViewFeedback;
        private Panel panelHeader;
        private Panel panelContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Metro Service - Feedback Form";
            this.Size = new Size(1270, 700);  // **Updated Size**
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.White;

            // Apply Smooth Gradient Background
            this.Paint += new PaintEventHandler(FormBackground_Paint);

            // Header Panel
            panelHeader = new Panel
            {
                Size = new Size(1270, 80),  // **Wider Header**
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(41, 128, 185) // Elegant Blue Header
            };

            // Title Label
            lblTitle = new Label
            {
                Text = "Metro Service Feedback",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(450, 20)
            };

            // Main Container Panel
            panelContainer = new Panel
            {
                Size = new Size(1100, 500),
                Location = new Point(80, 120),  // **Centered Layout**
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblStation = new Label
            {
                Text = "Select Station:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(50, 50),
                AutoSize = true
            };

            cmbStation = new ComboBox
            {
                Location = new Point(200, 50),
                Size = new Size(400, 35),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 12)
            };

            // Metro Stations (Fixed Duplicates)
            string[] metroStations = new string[]
            {
                "Uttara North", "Uttara Center", "Uttara South", "Pallabi", "Mirpur 11",
                "Mirpur 10", "Kazipara", "Shewrapara", "Agargaon", "Bijoy Sarani",
                "Farmgate", "Karwan Bazar", "Shahbagh", "Dhaka University",
                "Bangladesh Secretariat", "Motijheel", "Kamalapur"
            };

            cmbStation.Items.Clear();
            cmbStation.Items.AddRange(metroStations.Distinct().ToArray());

            lblRating = new Label
            {
                Text = "Rating (1-5):",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(50, 100),
                AutoSize = true
            };

            cmbRating = new ComboBox
            {
                Location = new Point(200, 100),
                Size = new Size(100, 35),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 12)
            };

            // **Fixed Duplicate Rating Issue**
            cmbRating.Items.Clear();
            cmbRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });

            lblEmail = new Label
            {
                Text = "Email:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(50, 150),
                AutoSize = true
            };

            txtEmail = new TextBox
            {
                Location = new Point(200, 150),
                Size = new Size(400, 35),
                Font = new Font("Segoe UI", 12),
                BackColor = Color.White
            };

            lblTitle = new Label
            {
                Text = "Enter Feedback:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(50, 200),
                AutoSize = true
            };

            txtFeedback = new TextBox
            {
                Location = new Point(200, 200),
                Size = new Size(600, 100),
                Multiline = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 12)
            };

            // Submit Button
            btnSubmit = new Button
            {
                Text = "Submit Feedback",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                BackColor = Color.FromArgb(41, 128, 185), // **Modern Blue Button**
                ForeColor = Color.White,
                Location = new Point(200, 320),
                Size = new Size(400, 50),
                FlatStyle = FlatStyle.Flat
            };
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Click += new EventHandler(BtnSubmit_Click);

            // Feedback List DataGridView
            dataGridViewFeedback = new DataGridView
            {
                Location = new Point(50, 400),
                Size = new Size(1000, 150),
                BackgroundColor = Color.White,
                AllowUserToAddRows = false,
                ReadOnly = true
            };

            panelHeader.Controls.Add(lblTitle);
            panelContainer.Controls.Add(lblStation);
            panelContainer.Controls.Add(cmbStation);
            panelContainer.Controls.Add(lblRating);
            panelContainer.Controls.Add(cmbRating);
            panelContainer.Controls.Add(lblEmail);
            panelContainer.Controls.Add(txtEmail);
            panelContainer.Controls.Add(lblTitle);
            panelContainer.Controls.Add(txtFeedback);
            panelContainer.Controls.Add(btnSubmit);
            panelContainer.Controls.Add(dataGridViewFeedback);

            this.Controls.Add(panelHeader);
            this.Controls.Add(panelContainer);
        }

        // Paint background gradient effect
        private void FormBackground_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                   Color.White, Color.LightBlue, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // Submit Button Event Handler
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feedback Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
