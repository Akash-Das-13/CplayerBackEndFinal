using PlayerAPI.Exceptions;
using PlayerAPI.Model;
using PlayerAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository repository;

        public PlayerService(IPlayerRepository _repository)
        {
            repository = _repository;
        }

        public Task<Player> GetPlayerByIdAsync(int id)
        {
            return repository.GetPlayerByIdAsync(id);
        }

        public Task<List<Data2>> GetPlayerByNameAsync(string name)
        {
            return repository.GetPlayerByNameAsync(name);
        }
    }
}
