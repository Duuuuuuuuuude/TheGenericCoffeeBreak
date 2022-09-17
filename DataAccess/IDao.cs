using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDao<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);  
        void Update(TEntity entity);
        void create(TEntity entity);
        void Delete(TEntity entity);
    }
}
