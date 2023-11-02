using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FrontEnd.Data
{
    public class FoodBoxDB : IdentityDbContext
    {
        public FoodBoxDB() 
        { 

        }
        public FoodBoxDB (DbContextOptions<FoodBoxDB> options) :base(options)
        {

        }
    }
}