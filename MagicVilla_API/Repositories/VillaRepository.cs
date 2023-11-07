using MagicVilla_API.Data;
using MagicVilla_API.Models;
using MagicVilla_API.Repositories.IRepositories;

namespace MagicVilla_API.Repositories
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Villa> Update(Villa entity)
        {
            entity.FechaActualizacion = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
