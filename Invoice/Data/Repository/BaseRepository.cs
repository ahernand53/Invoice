using Invoice.Core.Entities;
using Invoice.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Invoice.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly InvoiceDbContext _context;
        private DbSet<T> entities;
        string mensajeError = string.Empty;

        public BaseRepository(InvoiceDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public void Actualizar(T entity, int id)
        {
            throw new NotImplementedException();
        }

        public T Buscar(long id)
        {
            return entities.SingleOrDefault(entity => entity.ID == id);
        }

        public T Buscar(long id, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentException("Entity");
            }

            entities.Remove(Entity);
            _context.SaveChanges();
        }

        public void Insertar(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Todos()
        {
            return entities.Where(x => !x.Eliminado);
        }

        public IQueryable<T> Todos(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
