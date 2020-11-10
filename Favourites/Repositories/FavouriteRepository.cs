using Favourites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favourites.Repositories
{
    public class FavouriteRepository : IFavouriteRepository
    {
        private readonly DataContext db;
        public FavouriteRepository(DataContext dbcontext)
        {
            db = dbcontext;
        }
        public Favourite AddFavourite(Favourite favourite)
        {
            db.Favourites.Add(favourite);
             db.SaveChanges();
            return favourite;

        }

        public bool DeleteFavourite(int id)
        {
            Favourite fav = db.Favourites.Where(p => p.FavouriteId == id).FirstOrDefault();
             db.Favourites.Remove(fav);
            return db.SaveChanges() == 1;
        }

        public List<Favourite> GetAllFavouritesByUserId(string userId)
        {
            return db.Favourites.Where(p => p.CreatedBy == userId).ToList();
        }

        public Favourite GetFavourite(int id)
        {
            return db.Favourites.Where(p => p.FavouriteId == id).FirstOrDefault();
        }

        public List<Favourite> GetFavourites()
        {
            return db.Favourites.ToList();
        }
    }
}
