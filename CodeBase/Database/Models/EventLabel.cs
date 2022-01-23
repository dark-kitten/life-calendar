using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class EventLabel : AuditEntity
    {
        [Key]
        public Guid EventLabelID { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
