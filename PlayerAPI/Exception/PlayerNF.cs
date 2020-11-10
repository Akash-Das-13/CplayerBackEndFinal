using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Exceptions
{
    public class PlayerNF:ApplicationException
    {
        public PlayerNF(){ }
        public PlayerNF(string msg) : base(msg) { }
    }
}
