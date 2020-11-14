using AuthenticationService.Models;
using Microsoft.EntityFrameworkCore;
using Favourites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public  class DatabaseFixture:IDisposable
    {
       public AuthDbContext context;
        public DataContext favcontext;
        public DatabaseFixture()
        {
            var options = new DbContextOptionsBuilder<AuthDbContext>().UseInMemoryDatabase("AuthDB").Options;
           context = new AuthDbContext(options);
            var opt = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase("favdb").Options;
            favcontext = new DataContext(opt);
            
        }
        public void Dispose()
        {
         context = null;
        }
    }
}
