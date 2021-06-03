using System;
using System.Collections.Generic;
using System.Text;

namespace Glitter.Shared.DTO
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ContactNo { get; set; }
        public string ImageUrl { get; set; }

    }
}
