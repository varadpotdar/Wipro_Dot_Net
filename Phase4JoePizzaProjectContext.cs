using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Phase4JoePizzaProject.Models
{
    public class Phase4JoePizzaProjectContext : DbContext
    {
        public Phase4JoePizzaProjectContext (DbContextOptions<Phase4JoePizzaProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Phase4JoePizzaProject.Models.Order> Order { get; set; }
    }
}
