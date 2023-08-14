using ProEventos.Core.Entities;

namespace ProEventos.Application.InputModels
{
    public class AddEventInputModel
    {
        public string Title { get; set; }
        public string Place { get; set; }
        public int PublicSupport { get; set; }
        public DateTime EndDate { get; set; }
        public string ImgUrl { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
        public List<Instagram>? Instagrams { get; set; }
        public List<Speaker>? Speakers { get; set; }

        public Event ToEntity()
            => new(Title, Place, PublicSupport, EndDate, ImgUrl, WhatsApp, Email);

    }
}
