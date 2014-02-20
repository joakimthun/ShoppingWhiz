using ShoppingWhiz.Repository.Context;
using ShoppingWhiz.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWhiz.Repository.Crud
{
    public class ShoppingWhizRepository<TEntity> where TEntity : BaseEntity
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

        public void DeleteOne(int id)
        {
            using (var context = new ShoppingWhizContext())
            {
                var entity = context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
