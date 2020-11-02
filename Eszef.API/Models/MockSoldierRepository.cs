using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class MockSoldierRepository : ISoldierRepository
    {
        public IEnumerable<Soldier> GetAllSoldiers =>
            new List<Soldier>
            { 
                new Soldier { IdSoldier= 1, Name = "Adam",LastName =  "Malysz",Rank = "szer.pchor.", IdRoom = 1 },
                new Soldier { IdSoldier= 2, Name = "Kamil",LastName =  "Pudzianowski",Rank = "st. szer.pchor.",IdRoom = 5 },
                new Soldier { IdSoldier= 3, Name = "Adrian",LastName =  "Lewandowski",Rank = "kpr.pchor.",IdRoom = 10 },
                new Soldier { IdSoldier= 4, Name = "Pawel", LastName = "Abacki",Rank = "sierz.pchor.",IdRoom = 20 },
            };
        

        public Soldier GetSoldierById(int id) =>
            GetAllSoldiers.SingleOrDefault(x => x.IdSoldier == id);


        public IEnumerable<Soldier> GetSoldierByLastName(string lastname) =>
            GetAllSoldiers.Where(x => x.LastName == lastname);
    }
}
