using PlayerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Repository
{
    public interface IPlayerRepository 
    {
        Task<List<Data2>> GetPlayerByNameAsync(string name);
        Task<Player> GetPlayerByIdAsync(int id);

    }
    
}
