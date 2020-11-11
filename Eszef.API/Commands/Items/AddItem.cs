using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Commands.Items
{
    public class AddItem : ICommand
    {
        public string ItemName { get; set; }
        public int IdRoom { get; set; }
    }
}
