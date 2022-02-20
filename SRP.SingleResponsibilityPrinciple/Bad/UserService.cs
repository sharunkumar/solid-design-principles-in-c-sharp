using SRP.SingleResponsibilityPrinciple.CommonTypes;
using System.Activities;
using System.Linq;

namespace SRP.SingleResponsibilityPrinciple.Bad
{
    public class UserService
    {
        public User RegisterUser(string nome, string email)
        {
            if (!ValidateEmail(email))
                throw new ValidationException($"{nameof(email)} is not a valid email");

            DbContext dbContext = new DbContext();

            var user = new User(nome, email);

            var response = dbContext.Insert(user);

            if (response)
                SendEmail(new MailMessage(user.Email, $"Welcome, ${user.Name}"));

            return user;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }

        public bool SendEmail(MailMessage mensagem)
        {
            return MailServiceClient.Send(mensagem);
        }
    }
}
