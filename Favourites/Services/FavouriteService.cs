using Favourites.Exceptions;
using Favourites.Models;
using Favourites.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Services
{
    public class FavouriteService : IFavouriteService
    {
        private readonly IFavouriteRepository repo;
        public FavouriteService(IFavouriteRepository _repo)
        {
            repo = _repo;
        }
        public Favourite AddFavourite(Favourite favourite)
        {
            /*Favourite fav= repo.AddFavourite(favourite);*/
            Favourite fav = repo.GetFavourite(favourite.FavouriteId);
            if (fav == null)
            {
              return  repo.AddFavourite(favourite);
            }
            else
            {
                throw new PlayerAlreadyExistsException("already added to favourites");
            }
            

        }

        public bool DeleteFavourite(int id)
        {
            Favourite favourite = repo.GetFavourite(id);
            if(favourite==null)
            {
                throw new PlayerNotFoundException($"favourite with favourite id:{id} does not exists");
            }
            return repo.DeleteFavourite(id);
        }

        public List<Favourite> GetAllFavouritesByUserId(string userId)
        {
            return repo.GetAllFavouritesByUserId(userId);
        }

        public Favourite GetFavourite(int id)
        {
            Favourite favourite = repo.GetFavourite(id);
            if (favourite == null)
            {
                throw new PlayerNotFoundException($"favourite with favourite id:{id} does not exists");
            }
            return favourite;
        }

        public List<Favourite> GetFavourites()
        {
            return repo.GetFavourites();
        }
    }
}
