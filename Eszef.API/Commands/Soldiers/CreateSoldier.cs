using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Commands
{
    public class CreateSoldier : ICommand
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Rank { get; set; }
        public int IdRoom { get; set; }
    }
}
