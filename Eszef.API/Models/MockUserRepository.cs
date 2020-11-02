using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> GetAllUsers() =>
            new List<User>
            {
                new User { IdUser =1,Email = "adam@wp.pl",Name = "Adam",LastName= "Malysz",Kompania=2,Password="blablabla"},
                new User { IdUser =2,Email = "pawel@wp.pl",Name = "Pawel",LastName= "Milosz",Kompania=8,Password="blablabla"}
            };

        public User GetUserByEmail(string email) =>
           GetAllUsers().SingleOrDefault(x => x.Email == email);
    }
}
