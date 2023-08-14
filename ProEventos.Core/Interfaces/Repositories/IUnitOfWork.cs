namespace ProEventos.Core.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
