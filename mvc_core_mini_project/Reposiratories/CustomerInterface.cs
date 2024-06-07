using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public interface CustomerInterface
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(Int64 id);
        void Add(Customer rec);
        void Edit(Customer rec);
        void Delete(long id);
        void Details(long id);
    }
}
