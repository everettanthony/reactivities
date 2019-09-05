using System;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string DateFormatted { get => Date.ToString("MMMM d, yyyy"); }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Venue { get; set; }
        public bool IsActive { get; set; }
    }
}