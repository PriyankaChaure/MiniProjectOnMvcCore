using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public class CustomerRepo:CustomerInterface
    {
        CompanyContext cc;
        public CustomerRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Customer rec)
        {
            this.cc.Customers.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Details(long id)
        {
            var rec = this.cc.Customers.Find(id);
        }

        public void Edit(Customer rec)
        {

            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return this.cc.Customers.ToList();
        }

        public Customer GetCustomerById(long id)
        {
            return this.cc.Customers.Find(id);
        }

    }
}
