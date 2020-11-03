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
        public string IdSoldier { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string Rank { get; protected set; }
        public int IdRoom { get; protected set; }

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
