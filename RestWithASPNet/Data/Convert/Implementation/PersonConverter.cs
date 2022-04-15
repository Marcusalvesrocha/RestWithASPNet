using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPNet.Data.Convert.Contract;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Models;

namespace RestWithASPNet.Data.Convert.Implementation
{
    public class PersonConverter : IParser<Person, PersonVO>, IParser<PersonVO, Person>
    {
        public PersonConverter()
        {
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;

            return new PersonVO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LasrName = origin.LasrName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public IEnumerable<PersonVO> Parse(IEnumerable<Person> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;

            return new Person
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LasrName = origin.LasrName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public IEnumerable<Person> Parse(IEnumerable<PersonVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
