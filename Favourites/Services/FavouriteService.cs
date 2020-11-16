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
            Favourite fav = repo.NullFavourite(favourite);

            
            if (fav == null)
            {
              return  repo.AddFavourite(favourite);
            }
            else
            {
                throw new PlayerAlreadyExistsException("Already Added to Favourites");
            }
            

        }

        public bool DeleteFavourite(int pId, string userId)
        {
           
                return repo.DeleteFavourite( pId,  userId);

        }



        public List<Favourite> GetAllFavouritesByUserId(string userId)
        {

            Favourite fav = repo.AvailableFav(userId);


            if (fav == null)
            {
                throw new PlayerNotFoundException("Nothing is Added");
            }
            else
            {
               return repo.GetAllFavouritesByUserId(userId);
            }
        }

        

        

        public List<Favourite> GetRecommend()
        {
            var rec = repo.GetRecommend();
            if (rec == null)
            {
                throw new PlayerNotFoundException("No recommendation exists");
            }
            else
            {
                return repo.GetRecommend();
            }
        }
    }
}
