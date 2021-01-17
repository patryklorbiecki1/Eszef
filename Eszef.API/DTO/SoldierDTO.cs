using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.DTO
{
    public class SoldierDTO
    {
        public string IdSoldier { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Rank { get; set; }
        public int IdRoom { get; set; }
    }
}
