using ShoppingWhiz.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWhiz.Repository.Crud
{
    public class ShoppingWhizRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using(var context = new ShoppingWhizContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var context = new ShoppingWhizContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetOne(Func<TEntity, bool> predicate)
        {
            using (var context = new ShoppingWhizContext())
            {
                return context.Set<TEntity>().FirstOrDefault(predicate);
            }
        }
    }
}
