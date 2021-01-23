using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class User
    {
        [BsonId]
        public string IdUser { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public int Company { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public float Cost { get; set; }
        public User(string email, string password)
        {
            IdUser = Guid.NewGuid().ToString().Substring(0, 23);
            Email = email;     
            Password = password;
            Cost = 0;
        }
    
    }


}
