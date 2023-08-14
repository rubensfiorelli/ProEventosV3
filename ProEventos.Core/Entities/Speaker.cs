using ProEventos.Core.Common;

namespace ProEventos.Core.Entities
{
    public sealed class Speaker : EntityBase
    {
        public Speaker(string firstName, string lastName, string linkedin, string bio, string whatsApp, string email) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Linkedin = linkedin;
            Bio = bio;
            WhatsApp = whatsApp;
            Email = email;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Linkedin { get; private set; }
        public string Bio { get; private set; }
        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public List<Event>? Events { get; set; }

        public void Update(string newFistName, string newLastName, string newLinkedin, string newBio, string newWhatsApp, string newEmail)
        {
            FirstName = newFistName;
            LastName = newLastName;
            Linkedin = newLinkedin;
            Bio = newBio;
            WhatsApp = newWhatsApp;
            Email = newEmail;
        }
    }
}