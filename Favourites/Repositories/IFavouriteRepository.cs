using Favourites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Repositories
{
   public interface IFavouriteRepository
    {
        List<Favourite> GetFavourites();
        Favourite GetFavourite(int id);
        Favourite AddFavourite(Favourite favourite);
        bool DeleteFavourite(int id);
        List<Favourite> GetAllFavouritesByUserId(string userId);
    }
}
