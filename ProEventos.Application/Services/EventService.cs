using ProEventos.Application.InputModels;
using ProEventos.Application.Interfaces;
using ProEventos.Application.ViewModels;
using ProEventos.Core.Interfaces.Repository;

namespace ProEventos.Application.Services
{
    public class EventService : IEventService
    {
        protected readonly IEventRepository _repository;

        public EventService(IEventRepository repository)
        {
            _repository = repository;

        }
        public async Task AddAsync(AddEventInputModel model)
        {
            var evento = model.ToEntity();

            await _repository.AddAsync(evento);

            await _repository.Commit();

        }

        public void Delete(AddEventInputModel model)
        {
            var events = model.ToEntity();

            events.Delete();

        }

        public async Task<ICollection<EventViewModel>> GetAllAsync(bool includeSpeakers)
        {
            var services = await _repository.GetAllAsync(includeSpeakers);
            if (services is null)
                return null;

            return services
                .Select(s => new EventViewModel(s.Id,
                                                s.Title,
                                                s.Place,
                                                s.PublicSupport,
                                                s.StartDate,
                                                s.EndDate,
                                                s.ImgUrl,
                                                s.WhatsApp,
                                                s.Email,
                                                s.CreateAt,
                                                (DateTime)s.UpdateAt))
                .ToList();

        }

        public async Task<List<EventViewModel>> GetByPlaceAsync(string place, bool includeSpeakers)
        {
            var events = await _repository.GetByPlaceAsync(place, includeSpeakers);
            if (events is null)
                return null;

            return events
                .Select(s => new EventViewModel(s.Id,
                                                s.Title,
                                                s.Place,
                                                s.PublicSupport,
                                                s.StartDate,
                                                s.EndDate,
                                                s.ImgUrl,
                                                s.WhatsApp,
                                                s.Email,
                                                s.CreateAt,
                                                (DateTime)s.UpdateAt))
                .ToList();
        }

        public async Task<List<EventViewModel>> GetByTitleAsync(string title, bool includeSpeakers)
        {
            var events = await _repository.GetByTitleAsync(title, includeSpeakers);
            if (events is null)
                return null;

            return events
                .Select(s => new EventViewModel(s.Id,
                                                s.Title,
                                                s.Place,
                                                s.PublicSupport,
                                                s.StartDate,
                                                s.EndDate,
                                                s.ImgUrl,
                                                s.WhatsApp,
                                                s.Email,
                                                s.CreateAt,
                                                (DateTime)s.UpdateAt))
                .ToList();
        }

        public async Task<EventViewModel> GetIdAsync(Guid eventId, bool includeSpeakers)
        {
            var evento = await _repository.GetIdAsync(eventId, includeSpeakers);
            if (evento is null)
                return null;

            var model = new EventViewModel(
                evento.Id,
                evento.Title,
                evento.Place,
                evento.PublicSupport,
                evento.StartDate,
                evento.EndDate,
                evento.ImgUrl,
                evento.WhatsApp,
                evento.Email,
                evento.CreateAt,
                evento.UpdateAt);

            return model;

        }

    }
}
