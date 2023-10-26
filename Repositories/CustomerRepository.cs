using GRT_ASSIIGNMENT.Data;
using GRT_ASSIIGNMENT.Models;

namespace GRT_ASSIIGNMENT.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Customer Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Delete(int Id)
        {
            Customer customer = _context.Customers.Find(Id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public Customer GetById(int Id)
        {
            return _context.Customers.Where(x => x.CustomerID == Id).SingleOrDefault();
        }

        public Customer Update(Customer customer)
        {
            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return customer;
        }
    }
}
