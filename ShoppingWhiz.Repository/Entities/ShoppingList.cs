using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWhiz.Repository.Entities
{
    public class ShoppingList : BaseEntity
    {
        public ShoppingList()
        {
            Items = new List<ShoppingItem>();
        }

        public string Store { get; set; }

        public virtual IEnumerable<ShoppingItem> Items { get; set; }

        public double Total { get; set; }
    }
}
