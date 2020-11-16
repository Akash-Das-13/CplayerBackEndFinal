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
            var pCount = db.Favourites.Where(e => e.PId == favourite.PId).Count();
            
                var f = db.Favourites.AsQueryable();
                if (f.Count() == 0)
                {
                    favourite.FavouriteId = 101;
                }
                else
                {
                    int maxCategoryId = f.Max(c => c.FavouriteId) + 1;
                    favourite.FavouriteId = maxCategoryId;
                }
            Favourite favourite1 = new Favourite() {

                FavouriteId = favourite.FavouriteId,
                PId = favourite.PId,
                UserId = favourite.UserId,
                Name = favourite.Name,
                FullName = favourite.FullName,
                Count = pCount + 1,
                
            };
            

            db.Favourites.Add(favourite1);
            db.SaveChanges();
            return favourite1;
        }

        

        public bool DeleteFavourite(int pId, string userId)
        {
            var favourite = db.Favourites.Where(p => p.PId ==pId  && p.UserId== userId).FirstOrDefault();
            //var fav = favourite;
            var Dfav = NullFavourite(favourite);
            //var dFav = db.Favourites.Where(p => p.PId ==fav.PId  && p.UserId==fav.UserId).FirstOrDefault();
            db.Favourites.Remove(Dfav);
            return db.SaveChanges() == 1;
        }

        public List<Favourite> GetAllFavouritesByUserId(string userId)
        {
            return db.Favourites.Where(p => p.UserId == userId).ToList();
        }

       

        public List<Favourite> GetRecommend()
        {
            
            var maxC =db.Favourites.Max(prop => prop.Count);
            int aveC = maxC / 2;
            
            var recL= db.Favourites.Where(p => p.Count >= aveC).ToList();
            var bar = recL.GroupBy(x => x.PId).Select(x => x.First()).ToList();
            return bar;
        }

        public Favourite NullFavourite(Favourite favourite)
        {
            return db.Favourites.Where(p => p.PId == favourite.PId && p.UserId == favourite.UserId).FirstOrDefault();
            
        }

        public Favourite AvailableFav(string userId)
        {
            
            return db.Favourites.Where(p => p.UserId == userId).FirstOrDefault();
        }


    }
}
