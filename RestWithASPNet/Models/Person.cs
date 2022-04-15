using System;
using System.ComponentModel.DataAnnotations.Schema;
using RestWithASPNet.Models.Base;

namespace RestWithASPNet.Models
{
    [Table("person")]
    public class Person : BaseEntity
    {
        
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LasrName { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
