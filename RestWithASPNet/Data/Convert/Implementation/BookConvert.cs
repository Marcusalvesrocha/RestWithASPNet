using System.Collections.Generic;
using System.Linq;
using RestWithASPNet.Data.Convert.Contract;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Models;

namespace RestWithASPNet.Data.Convert.Implementation
{
    public class BookConvert : IParser<Book, BookVO>, IParser<BookVO, Book>
    {
        public BookConvert()
        {
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;

            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public IEnumerable<BookVO> Parse(IEnumerable<Book> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;

            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public IEnumerable<Book> Parse(IEnumerable<BookVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
