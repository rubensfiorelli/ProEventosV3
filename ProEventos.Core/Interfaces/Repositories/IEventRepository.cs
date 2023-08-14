using ProEventos.Core.Entities;

namespace ProEventos.Core.Interfaces.Repository
{
    public interface IEventRepository : IUnitOfWork
    {
        Task AddAsync(Event @event);
        Task<ICollection<Event>> GetAllAsync(bool includeSpeakers);
        Task<List<Event>> GetByTitleAsync(string title, bool includeSpeakers);
        Task<List<Event>> GetByPlaceAsync(string place, bool includeSpeakers);
        Task<Event> GetIdAsync(Guid eventId, bool includeSpeakers);

    }
}
