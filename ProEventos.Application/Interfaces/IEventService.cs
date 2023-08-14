using ProEventos.Application.InputModels;
using ProEventos.Application.ViewModels;

namespace ProEventos.Application.Interfaces
{
    public interface IEventService
    {
        Task AddAsync(AddEventInputModel model);
        void Delete(AddEventInputModel model);
        Task<ICollection<EventViewModel>> GetAllAsync(bool includeSpeakers);
        Task<List<EventViewModel>> GetByTitleAsync(string title, bool includeSpeakers);
        Task<List<EventViewModel>> GetByPlaceAsync(string place, bool includeSpeakers);
        Task<EventViewModel> GetIdAsync(Guid eventId, bool includeSpeakers);

    }
}
