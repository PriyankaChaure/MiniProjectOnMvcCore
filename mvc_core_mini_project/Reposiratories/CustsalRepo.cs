using mvc_core_mini_project.Models;
using System.Linq;

namespace mvc_core_mini_project.Reposiratories
{
    public class CustsalRepo : CustsalvmInterface
    {
        CompanyContext cc;
        public CustsalRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
      
        public void Add(custsalVM rec)
        {

            Customer c = new Customer();
          //  c.CustomerId = rec.CustomerId;
            c.CustomerName = rec.CustomerName;
            c.CustomerAddress = rec.CustomerAddress;
            c.CustomerEmail = rec.CustomerEmail;
            c.CustomerPhone = rec.CustomerPhone;
            this.cc.Customers.Add(c);

            Sales s = new Sales();
            rec.SalesDate = DateTime.Now;
            s.SalesDate = rec.SalesDate;
           // s.CustomerId = rec.CustomerId;
            s.BookId = rec.BookId;
            s.Price = rec.Price;
            s.Qty = rec.Qty;
            //  s.Customer.Add(c);
            s.Customer = c;
            this.cc.Sales.Add(s);

            this.cc.SaveChanges();

        }

        public custsalVM GetId(long id)
        {
            var rec = (from t1 in this.cc.Sales
                       join t2 in this.cc.Customers
                       on t1.CustomerId equals t2.CustomerId
                       join t3 in this.cc.Books
                       on t1.BookId equals t3.BookId
                       where t1.SalesId == id

                       select new custsalVM
                       {
                           SalesId = t1.SalesId,
                           CustomerId = t2.CustomerId,
                           CustomerName = t2.CustomerName,
                           CustomerAddress = t2.CustomerAddress,
                           CustomerEmail = t2.CustomerEmail,
                           CustomerPhone = t2.CustomerPhone,
                           BookId = t1.BookId,
                           BookName = t3.BookName,
                           Qty = t1.Qty,
                           Price = t1.Price,
                       }).FirstOrDefault();
            return rec;
        }

        public void Edit(custsalVM rec)
        {

            Sales s = this.cc.Sales.Find(rec.SalesId);
            rec.SalesDate = DateTime.Now;
            s.SalesDate = rec.SalesDate;
            s.CustomerId = rec.CustomerId;
            s.BookId = rec.BookId;
            s.Qty = rec.Qty;
            s.Price = rec.Price;


            Customer c = this.cc.Customers.Find(rec.CustomerId);
            c.CustomerName = rec.CustomerName;
            c.CustomerAddress = rec.CustomerAddress;
            c.CustomerEmail = rec.CustomerEmail;
            c.CustomerPhone = rec.CustomerPhone;

            Book b = this.cc.Books.Find(rec.BookId);
            b.BookId = rec.BookId;
            b.BookName = rec.BookName;

            this.cc.SaveChanges();
        }

      
    }
}
