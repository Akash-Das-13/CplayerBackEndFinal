using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Exceptions
{
    public class PlayerAlreadyExistsException:ApplicationException
    {
        public PlayerAlreadyExistsException() { }
        public PlayerAlreadyExistsException(string message) : base(message) { }
    }
}
