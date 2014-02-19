using ShoppingWhiz.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWhiz.Repository.Context
{
    public class ShoppingWhizContext : DbContext
    {
        public ShoppingWhizContext()
            : base("name=DefaultConnection")
        { 
        }

        public DbSet<ShoppingList> Lists { get; set; }

        public DbSet<ShoppingItem> Items { get; set; }
    }
}
