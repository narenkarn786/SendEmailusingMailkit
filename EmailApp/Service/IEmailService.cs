using EmailApp.Model;

namespace EmailApp.Service
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
