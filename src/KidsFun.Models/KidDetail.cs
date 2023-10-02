using System.Net.Mail;

namespace KidsFun.Models
{
    public record KidDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public MailAddress? Email { get; set; }

        public int points { get; set; }
    }
}