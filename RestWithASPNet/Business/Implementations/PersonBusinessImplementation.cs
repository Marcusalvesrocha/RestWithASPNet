using System.Collections.Generic;
using RestWithASPNet.Data.Convert.Implementation;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Models;
using RestWithASPNet.Repository;

namespace RestWithASPNet.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness<PersonVO>
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public IEnumerable<PersonVO> FindAll()
        {

            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {

            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Create(PersonVO item)
        {
            var person = _converter.Parse(item);
            return _converter.Parse(_repository.Create(person));
        }

        public PersonVO Update(PersonVO item)
        {

            var person = _converter.Parse(item);
            return _converter.Parse(_repository.Update(person));
        }

        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
