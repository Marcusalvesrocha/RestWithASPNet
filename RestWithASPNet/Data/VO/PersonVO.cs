
using System.Collections.Generic;
using RestWithASPNet.Hypermidia;
using RestWithASPNet.Hypermidia.Abstract;

namespace RestWithASPNet.Data.VO
{
    
    public class PersonVO : ISupportHyperMedia
    {

        public long Id { get; set; }

        public string FirstName { get; set; }
        
        public string LasrName { get; set; }
        
        public string Address { get; set; }
        
        public string Gender { get; set; }

        public List<HyperMidiaLink> Links { get; set; } = new List<HyperMidiaLink>();
    }
}
