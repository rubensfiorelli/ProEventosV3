using ProEventos.Core.Entities;

namespace ProEventos.Core.Interfaces.Repository
{
    public interface ISpeakerRepository : IUnitOfWork
    {
        Task AddAsync(Speaker speaker);
        Task<IList<Speaker>> GetAllAsync(bool includeEvents);
        Task<IList<Speaker>> GetByLastNameAsync(string lastName, bool includeEvents);
        Task<Speaker> GetIdAsync(Guid speakerId, bool includeEvents);

    }
}
