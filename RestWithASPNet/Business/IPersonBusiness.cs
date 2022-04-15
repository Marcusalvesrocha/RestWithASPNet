using System;
using System.Collections.Generic;

namespace RestWithASPNet.Business
{
    public interface IPersonBusiness<PersonVO>
    {
        IEnumerable<PersonVO> FindAll();
        PersonVO FindById(long id);
        PersonVO Create(PersonVO item);
        PersonVO Update(PersonVO item);
        void Delete(long id);
    }
}
