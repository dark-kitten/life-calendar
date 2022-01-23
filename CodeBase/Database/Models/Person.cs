using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class Person : AuditEntity
    {
        [Key]
        public Guid PersonID { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
        public DateTime? BirthDate { get; set; }

        [MaxLength(128)]
        public string? Country { get; set; }

        public Account Account { get; set; }
        public Guid? AccountID { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
