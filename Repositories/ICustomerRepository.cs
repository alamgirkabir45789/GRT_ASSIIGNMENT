using GRT_ASSIIGNMENT.Models;

namespace GRT_ASSIIGNMENT.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetById(int Id);
        IEnumerable<Customer> GetAll();

        Customer Add(Customer customer);
        Customer Update(Customer customer);
        Customer Delete(int Id);
    }
}
