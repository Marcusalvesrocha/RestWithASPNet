using System.Collections.Generic;

namespace RestWithASPNet.Data.Convert.Contract
{
    public interface IParser<O, D>
    {
        D Parse(O origin);
        IEnumerable<D> Parse(IEnumerable<O> origin);
    }
}

