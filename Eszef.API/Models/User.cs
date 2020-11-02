using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public String Email { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public int Kompania { get; set; }
        public String Password { get; set; }
    }
}
