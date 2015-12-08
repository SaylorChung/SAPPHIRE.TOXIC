using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using SAPPHIRE.TOXIC.Services.Application;
using SAPPHIRE.TOXIC.Services.Models;

namespace SAPPHIRE.TOXIC.Services.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        #region Private Properties
        private readonly ICustomerService _customerServiceImpl;
        #endregion

        #region Ctor
        public ValuesController(ICustomerService customerService)
        {
            this._customerServiceImpl = customerService;
        }
        #endregion

        #region Services Methods
        // GET: api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerServiceImpl.GetAllCustomers();
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
