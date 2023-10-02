namespace KidsFun.Models
{
    public record TaskAssignment
    {
        public KidDetail Kid { get; set; }

        public TaskType Type { get; set; }

        public DateTime Due { get; set; }

        public TaskStatus Status { get; set; }

        public int Points { get; set; }

    }
}