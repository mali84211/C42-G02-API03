using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<TEntity,TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly StoreDbContext _context;
        public GenericRepository (StoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            if (typeof(TEntity) == typeof(Product))
            {
                return (IEnumerable<TEntity>) await _context.Products.Include(P=>P.Brand).Include(P=>P.Type).ToListAsync();
            }
            return await _context.GetAllAsync();
        }
    }
}
