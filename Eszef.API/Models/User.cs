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
        public string IdUser { get; protected set; }
        public string Email { get; protected set; }
        public string UserName { get; protected set; }
        public string LastName { get; protected set; }
        public int Company { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }

        public User(string email, string password)
        {
            IdUser = Guid.NewGuid().ToString().Substring(0, 23);
            Email = email;     
            Password = password;
        }
    }


}
