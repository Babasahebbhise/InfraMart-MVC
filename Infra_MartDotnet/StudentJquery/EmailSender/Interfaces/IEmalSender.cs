namespace StudentJquery.EmailSender.Interfaces
{
    public interface IEmalSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
