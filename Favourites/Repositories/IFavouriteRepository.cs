using Favourites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Repositories
{
   public interface IFavouriteRepository
    {
        List<Favourite> GetRecommend();

        Favourite NullFavourite(Favourite favourite);
        Favourite AddFavourite(Favourite favourite);
        bool DeleteFavourite(Favourite favourite);
        List<Favourite> GetAllFavouritesByUserId(string userId);

        Favourite AvailableFav(string userId);

    }
}
