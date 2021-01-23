using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class Soldier
    {
        [BsonId]
        public string IdSoldier { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Rank { get; set; }
        public int IdRoom { get; set; }

        private Soldier() { }
        public Soldier(string name,string lastname,string rank,int idroom)
        {
            IdSoldier = Guid.NewGuid().ToString().Substring(0, 23);
            Name = name;
            LastName = lastname;
            Rank = rank;
            IdRoom = idroom;
        }
    }
}
