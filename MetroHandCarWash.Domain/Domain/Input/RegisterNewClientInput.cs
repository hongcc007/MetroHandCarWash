using System;
using System.Collections.Generic;
using System.Text;

namespace MetroHandCarWash.Domain.Domain.Input
{
    public class RegisterNewClientInput
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
