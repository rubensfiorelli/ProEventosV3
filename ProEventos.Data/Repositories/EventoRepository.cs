using Microsoft.EntityFrameworkCore;
using ProEventos.Core.Entities;
using ProEventos.Core.Interfaces.Repository;
using ProEventos.Data.DatabaseContext;

namespace ProEventos.Data.Repositories
{
    public class EventoRepository : IEventRepository
    {

        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<Event> _dataset;

        public EventoRepository(ApplicationDbContext context)
        {
            _context = context;
            _dataset = context.Set<Event>();
        }

        public async Task AddAsync(Event @event)
        {
            try
            {
                @event.CreateAt = DateTime.UtcNow;
                await _dataset.AddAsync(@event);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public async Task<ICollection<Event>> GetAllAsync(bool includeSpeakers)
        {
            try
            {
                IQueryable<Event> query = _dataset.AsQueryable();

                query.Include(p => p.Speakers)
                     .Include(p => p.Batches)
                     .Include(p => p.Instagrams)
                     .Take(40)
                     .AsNoTracking();

                query.OrderBy(d => d.StartDate);


                return await query.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Event>> GetByPlaceAsync(string place, bool includeSpeakers)
        {
            try
            {
                IQueryable<Event> query = _dataset.AsQueryable();

                query.Include(p => p.Speakers)
                     .Include(p => p.Batches)
                     .Include(p => p.Instagrams)
                     .Take(40)
                     .AsNoTracking();

                query.OrderBy(d => d.StartDate)
                     .Where(s => s.Place.Normalize().Contains(place.Normalize()));


                return await query.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Event>> GetByTitleAsync(string title, bool includeSpeakers)
        {
            try
            {
                IQueryable<Event> query = _dataset.AsQueryable();

                query.Include(p => p.Speakers)
                     .Include(p => p.Batches)
                     .Include(p => p.Instagrams)
                     .Take(40)
                     .AsNoTracking();

                query.OrderBy(d => d.StartDate)
                     .Where(s => s.Title.Normalize().Contains(title.Normalize()));


                return await query.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Event> GetIdAsync(Guid eventId, bool includeSpeakers)
        {
            try
            {
                IQueryable<Event> query = _dataset.AsQueryable();

                query.Include(p => p.Speakers)
                     .Include(p => p.Batches)
                     .Include(p => p.Instagrams)
                     .Take(40)
                     .AsNoTracking();

                query.OrderBy(d => d.StartDate)
                     .Where(s => s.Id.Equals(eventId));


                return await query.SingleOrDefaultAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
