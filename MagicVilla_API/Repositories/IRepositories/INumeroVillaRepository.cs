using MagicVilla_API.Models;

namespace MagicVilla_API.Repositories.IRepositories
{
    public interface INumeroVillaRepository : IRepository<NumeroVilla>
    {
        Task<NumeroVilla> Update(NumeroVilla entity);
    }
}
