using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.DTO
{
    public class ItemDTO
    {
        public string Id { get;  set; }
        public string ItemName { get;  set; }
        public int IdRoom { get;  set; }
        public bool IsRepaired { get; set; }
    }
}
