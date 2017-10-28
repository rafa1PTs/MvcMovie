using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie_150221056.Models
{
    public class MvcMovie_150221056Context : DbContext
    {
        public MvcMovie_150221056Context (DbContextOptions<MvcMovie_150221056Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_150221056.Models.Movie> Movie { get; set; }
    }
}
