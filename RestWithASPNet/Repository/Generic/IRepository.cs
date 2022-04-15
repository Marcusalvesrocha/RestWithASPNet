using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestWithASPNet.Models;
using RestWithASPNet.Models.Base;

namespace RestWithASPNet.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        IEnumerable<T> FindAll();
        T FindById(long id);
        T Create(T item);
        T Update(T item);
        void Delete(long id);
    }
}
