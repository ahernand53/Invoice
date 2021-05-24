using Invoice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Invoice.Core.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        IQueryable<T> Todos();
        IQueryable<T> Todos(params Expression<Func<T, Object>>[] includeProperties);
        T Buscar(long id);
        T Buscar(Int64 id, params Expression<Func<T, Object>>[] includeProperties);
        void Insertar(T entity);
        void Actualizar(T entity, int id);
        void Eliminar(T Entity);
    }
}
