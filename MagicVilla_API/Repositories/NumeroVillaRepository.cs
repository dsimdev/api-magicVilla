using MagicVilla_API.Data;
using MagicVilla_API.Models;
using MagicVilla_API.Repositories.IRepositories;

namespace MagicVilla_API.Repositories
{
    public class NumeroVillaRepository : Repository<NumeroVilla>, INumeroVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public NumeroVillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<NumeroVilla> Update(NumeroVilla entity)
        {
            entity.FechaActualizacion = DateTime.Now;
            _db.NumeroVillas.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
