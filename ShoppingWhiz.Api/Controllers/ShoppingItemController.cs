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
    public class ShoppingItemController : ApiController
    {
        private readonly ShoppingWhizRepository<ShoppingItem> _repository = new ShoppingWhizRepository<ShoppingItem>();

        // GET api/ShoppingItem
        public IEnumerable<ShoppingItem> Get()
        {
            return _repository.GetAll();
        }

        // GET api/ShoppingItem/5
        public ShoppingItem Get(int id)
        {
            return _repository.GetOne(x => x.Id == id);
        }

        // POST api/ShoppingItem
        public void Post([FromBody]ShoppingItem item)
        {
            _repository.Add(item);
        }

        // PUT api/ShoppingItem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/ShoppingItem/5
        public void Delete(int id)
        {
        }
    }
}
