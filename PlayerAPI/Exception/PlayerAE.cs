using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Exceptions
{
    public class PlayerAE : ApplicationException
    {
        public PlayerAE() { }
        public PlayerAE(string msg) : base(msg) { }
    }
}
