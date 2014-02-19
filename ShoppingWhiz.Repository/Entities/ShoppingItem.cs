using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWhiz.Repository.Entities
{
    public class ShoppingItem : BaseEntity
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
