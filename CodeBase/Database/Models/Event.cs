using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class Event : AuditEntity
    {
        [Key]
        public Guid EventID { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }

        [MaxLength(1024)]
        public string? Description { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public Person Person { get; set; }
        public EventLabel EventLabel { get; set; }
    }
}
