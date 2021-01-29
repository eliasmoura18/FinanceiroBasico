using FinanceiroBasico.Model.Base;
using FinanceiroBasico.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private SQLServerContext _context;
        private DbSet<T> _dataset;

        public GenericRepository(SQLServerContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                _dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(int id)
        {
            return _dataset.SingleOrDefault(p => p.id.Equals(id));
        }

        public T Update(T item)
        {
            var result = _dataset.SingleOrDefault(p => p.id.Equals(item.id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            var result = _dataset.SingleOrDefault(p => p.id.Equals(id));
            if (result != null)
            {
                try
                {
                    _dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public bool IsExiste(int id)
        {
            return _dataset.Any(p => p.id.Equals(id));
        }
    }
}
