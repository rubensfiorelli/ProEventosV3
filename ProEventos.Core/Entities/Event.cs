using ProEventos.Core.Common;

namespace ProEventos.Core.Entities
{
    public sealed class Event : EntityBase
    {
        public Event(string title,
            string place,
            int publicSupport,
            DateTime endDate,
            string imgUrl,
            string whatsApp,
            string email) : base()
        {
            Title = title;
            Place = place;
            PublicSupport = publicSupport;
            StartDate = DateTime.Today;
            EndDate = endDate;
            ImgUrl = imgUrl;
            WhatsApp = whatsApp;
            Email = email;
            IsDeleted = false;
            Batches = new();
            Instagrams = new();
            Speakers = new();
        }

        public string Title { get; private set; }
        public string Place { get; private set; }
        public int PublicSupport { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string ImgUrl { get; private set; }
        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Batch>? Batches { get; set; }
        public List<Instagram>? Instagrams { get; set; }
        public List<Speaker>? Speakers { get; set; }


        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(string newTitle, string newPlace, int publicSupport, DateTime newEndDate, string newImgUrl, string newWhatsApp, string newEmail)
        {
            Title = newTitle;
            Place = newPlace;
            PublicSupport = publicSupport;
            EndDate = newEndDate;
            ImgUrl = newImgUrl;
            WhatsApp = newWhatsApp;
            Email = newEmail;
        }
    }
}
