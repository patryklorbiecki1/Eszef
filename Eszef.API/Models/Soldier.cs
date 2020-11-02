using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class Soldier
    {
        [Key]
        public int IdSoldier { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Rank { get; set; }
        public int IdRoom { get; set; }

    }
}
