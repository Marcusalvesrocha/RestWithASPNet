using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNet.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
