using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Exceptions
{
    public class PlayerNotFoundException:ApplicationException
    {
        
            public PlayerNotFoundException() { }
            public PlayerNotFoundException(string message) : base(message) { }
        
    }
}
