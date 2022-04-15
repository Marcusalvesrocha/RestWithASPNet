using System.Collections.Generic;

namespace RestWithASPNet.Business
{
    public interface IBookBusiness<BookVO>
    {
        IEnumerable<BookVO> FindAll();
        BookVO FindById(long id);
        BookVO Create(BookVO item);
        BookVO Update(BookVO item);
        void Delete(long id);
    }
}
