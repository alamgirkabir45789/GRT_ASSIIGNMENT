using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GRT_ASSIIGNMENT.Data;
using GRT_ASSIIGNMENT.Models;
using GRT_ASSIIGNMENT.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace GRT_ASSIIGNMENT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customer
        [HttpGet]
        public ActionResult GetCustomers()
        {
            var customer=  _customerRepository.GetAll();
            return Ok(customer);
        }

        [Authorize]
        // GET: api/Customer/5
        [HttpGet("{id}")]
        public  ActionResult GetCustomer(int id)
        {
            var customer = _customerRepository.GetById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public  IActionResult PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustomerID)
            {
                return BadRequest();
            }

           var updatedCustomer= _customerRepository.Update(customer);

           

            return Ok(updatedCustomer);
        }

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public  ActionResult PostCustomer(Customer customer)
        {
            var newCustomer = _customerRepository.Add(customer);
            return Ok(customer);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteCustomer(int id)
        {
            var customer =  _customerRepository.Delete(id);
            return Ok(customer);
        }

       
    }
}
