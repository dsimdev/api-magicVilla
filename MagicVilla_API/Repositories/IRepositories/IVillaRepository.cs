using MagicVilla_API.Models;

namespace MagicVilla_API.Repositories.IRepositories
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> Update(Villa entity);
    }
}
