using ProEventos.Core.Entities;

namespace ProEventos.Application.ViewModels
{
    public class EventViewModel
    {
        public EventViewModel(Guid id,
        string title,
        string place,
        int publicSupport,
        DateTime startDate,
        DateTime endDate,
        string imgUrl,
        string whatsApp,
        string email,
        DateTime createAt,
        DateTime? updateAt)
        {
            Id = id;
            Title = title;
            Place = place;
            PublicSupport = publicSupport;
            StartDate = startDate;
            EndDate = endDate;
            ImgUrl = imgUrl;
            WhatsApp = whatsApp;
            Email = email;
            CreateAt = createAt;
            UpdateAt = (DateTime)updateAt;
            Instagrams = new();
            Speakers = new();
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Place { get; private set; }
        public int PublicSupport { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string ImgUrl { get; private set; }
        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public List<Instagram>? Instagrams { get; set; }
        public List<Speaker>? Speakers { get; set; }


        public static EventViewModel FromEntity(Event entity)
        {
            return new EventViewModel(entity.Id,
                                      entity.Title,
                                      entity.Place,
                                      entity.PublicSupport,
                                      entity.StartDate,
                                      entity.EndDate,
                                      entity.ImgUrl,
                                      entity.WhatsApp,
                                      entity.Email,
                                      entity.CreateAt,
                                      (DateTime)entity.UpdateAt);


        }

    }
}
