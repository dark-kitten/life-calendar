using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Account : AuditEntity
    {
        [Key]
        public Guid AccountID { get; set; }

        [MaxLength(320)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Password { get; set; }

        public AccountType AccountType { get; set; }

        public Person Person { get; set; }
        public Guid PersonID { get; set; }
    }
}