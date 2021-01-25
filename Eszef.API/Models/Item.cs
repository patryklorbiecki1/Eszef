using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class Item
    {
        [BsonId]
        public string Id { get; set; }
        public string ItemName { get; set; }
        public int IdRoom { get; set; }
        public bool IsRepaired { get; set; }
        public Item(string itemName, int idRoom)
        { 
            Id = Guid.NewGuid().ToString().Substring(0, 23);
            ItemName = itemName;
            IdRoom = idRoom;
            Random rand = new Random();
            if (rand.Next(1, 10) == 1) IsRepaired = false;
            else IsRepaired = true;
        }

        public void Repair()
        {
            IsRepaired = true;
        }
    }
}
