using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroHandCarWash.Domain.Context
{
    [Table("Client", Schema = "dbo")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string CreationDate { get; set; }
        public string ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
