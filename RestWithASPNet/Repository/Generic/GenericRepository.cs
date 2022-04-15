using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestWithASPNet.Models.Base;
using RestWithASPNet.Models.Context;

namespace RestWithASPNet.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public IEnumerable<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.Find(id);
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public T Update(T item)
        {
            var exist = dataset.Any(p => p.Id.Equals(item.Id));

            if (!exist) return null;

            try
            {
                var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
                if (result != null)
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return item;
        }

        void IRepository<T>.Delete(long id)
        {
            try
            {
                var exist = dataset.Any(p => p.Id.Equals(id));

                if (exist)
                {
                    //var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                    var x = dataset.SingleOrDefault(p => p.Id.Equals(id));
                    try
                    {

                        dataset.Remove(x);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
