using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public int Company { get; set; }  
        public float Cost { get; set; }
    }
}
