using System;

namespace FeedbackSystem
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public string? StationLocation { get; set; }
        public string? FeedbackMessage { get; set; }
        public int Rating { get; set; }
        public DateTime FeedbackTime { get; set; }
        public string? Email { get; set; }

        public Feedback() { }

        public Feedback(int userId, string station, string message, int rating, string email)
        {
            UserId = userId;
            StationLocation = station;
            FeedbackMessage = message;
            Rating = rating;
            FeedbackTime = DateTime.Now;
            Email = email;
        }
    }
}
