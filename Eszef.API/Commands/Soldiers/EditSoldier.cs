using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Commands.Soldiers
{
    public class EditSoldier
    {
        public string LastName { get; set; }
        public string  Rank { get; set; }
        public int idRoom { get; set; }
    }
}
