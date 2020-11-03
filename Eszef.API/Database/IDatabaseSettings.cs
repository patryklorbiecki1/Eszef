using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Database
{
    public interface IDatabaseSettings
    { 
         string ConnectionString { get; set; }
         string Database { get; set; }
    }
}
