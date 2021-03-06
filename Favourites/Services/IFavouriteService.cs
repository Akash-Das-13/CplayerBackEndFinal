﻿using Favourites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Services
{
   public interface IFavouriteService
    {
        List<Favourite> GetRecommend();

        
        Favourite AddFavourite(Favourite favourite);
        bool DeleteFavourite(int pId, string userId);
        List<Favourite> GetAllFavouritesByUserId(string userId);
    }
}
