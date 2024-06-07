using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public class SalesRepo:SalesInterface
    {
        CompanyContext cc;
        public SalesRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Sales rec)
        {
            this.cc.Sales.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Sales.Find(id);
            this.cc.Sales.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Details(long id)
        {
            var rec = this.cc.Sales.Find(id);
        }

        public void Edit(Sales rec)
        {

            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Sales> GetAllSales()
        {
            return this.cc.Sales.ToList();
        }

        public Sales GetSalesById(long id)
        {
            return this.cc.Sales.Find(id);
        }
    }
}
