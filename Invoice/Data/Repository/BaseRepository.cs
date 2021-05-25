using Invoice.Core.Entity;
using Invoice.Core.Interface;
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
            if (entity == null)
            {
                throw new ArgumentException("Entity");
            }

            T existe = entities.Find(id);

            if (existe != null)
            {
                _context.Entry(existe).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }

            _context.SaveChanges();
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
            if (entity == null)
            {
                throw new ArgumentException("Entity");
            }
            entities.Add(entity);
            _context.SaveChanges();
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
