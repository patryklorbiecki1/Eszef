using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class Room
    {
        public IEnumerable<Item> items { get; protected set; }
        public IEnumerable<Soldier> soldiers { get; protected set; }

        public Room(IEnumerable<Item> items, IEnumerable<Soldier> soldiers)
        {
            this.items = items;
            this.soldiers = soldiers;
        }
    }
}
