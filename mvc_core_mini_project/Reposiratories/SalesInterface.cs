using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public interface SalesInterface
    {
        List<Sales> GetAllSales();
        Sales GetSalesById(Int64 id);
        void Add(Sales rec);
        void Edit(Sales rec);
        void Delete(long id);
        void Details(long id);
    }
}
