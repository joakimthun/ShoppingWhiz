using ShoppingWhiz.Repository.Crud;
using ShoppingWhiz.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingWhiz.Api.Controllers
{
    [Authorize]
    public class ShoppingListController : ApiController
    {
        private readonly ShoppingWhizRepository<ShoppingList> _repository = new ShoppingWhizRepository<ShoppingList>();

        // GET api/ShoppingList
        public IEnumerable<ShoppingList> Get()
        {
            return _repository.GetAll();
        }

        // GET api/ShoppingList/5
        public ShoppingList Get(int id)
        {
            return _repository.GetOne(x => x.Id == id);
        }

        // POST api/ShoppingList
        public void Post([FromBody]ShoppingList list)
        {
            _repository.Add(list);
        }

        // PUT api/ShoppingList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/ShoppingList/5
        public void Delete(int id)
        {
        }
    }
}
