using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Data.IRepositories
{
    public  interface IRepository<TEntity>
    {
        Task<bool>DeleteAsync(long  id);
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(long id);
        Task<TEntity>UpdateAsync(TEntity entity);
        Task<TEntity>CreateAsync(TEntity entity);


    }
}
