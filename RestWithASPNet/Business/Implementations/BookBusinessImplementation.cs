using System.Collections.Generic;
using RestWithASPNet.Data.Convert.Implementation;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Models;
using RestWithASPNet.Repository;

namespace RestWithASPNet.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness<BookVO>
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConvert _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConvert();
        }

        public IEnumerable<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Create(BookVO item)
        {
            var book = _converter.Parse(item);
            return _converter.Parse(_repository.Create(book));
        }

        public BookVO Update(BookVO item)
        {
            var book = _converter.Parse(item);
            return _converter.Parse(_repository.Update(book));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}


