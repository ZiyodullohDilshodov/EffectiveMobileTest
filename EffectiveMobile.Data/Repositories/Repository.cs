using Microsoft.EntityFrameworkCore;
using EffectiveMobile.Domain.Commons;
using EffectiveMobile.Data.DbContexts;
using EffectiveMobile.Data.IRepositories;

namespace EffectiveMobile.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly EffectiveMobileDbContext _AppDbContext;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(EffectiveMobileDbContext effectiveMobileDbContext)
        {
            _AppDbContext = effectiveMobileDbContext;
            _dbSet= _AppDbContext.Set<TEntity>();

        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var data = await _AppDbContext.AddAsync(entity);
            await _AppDbContext.SaveChangesAsync();

            return data.Entity;
        }

        public async Task<bool> DeleteAsync(long  id)
        {
            var searchData = await _dbSet.FirstOrDefaultAsync(x=>x.Id == id);
            var answer = _AppDbContext.Remove(searchData);

            return await _AppDbContext.SaveChangesAsync() > 0;
        }

        public IQueryable<TEntity> GetAll()
            => _dbSet;


        public async Task<TEntity> GetByIdAsync(long  id)
            => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var data = _dbSet.Update(entity);
            await _AppDbContext.SaveChangesAsync();
            return data.Entity;
        }
    }
}
