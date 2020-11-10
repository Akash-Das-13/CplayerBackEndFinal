using PlayerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Services
{
    public interface IPlayerService
    {
        Task<List<Data2>> GetPlayerByNameAsync(string name);
        Task<Player> GetPlayerByIdAsync(int id);
    }
}
