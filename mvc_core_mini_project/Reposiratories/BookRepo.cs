using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public class BookRepo : BookInterface
    {
        CompanyContext cc;
        public BookRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Book rec)
        {
            this.cc.Books.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Books.Find(id);
            this.cc.Books.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Details(long id)
        {
            var rec = this.cc.Books.Find(id);
        }

        public void Edit(Book rec)
        {

            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return this.cc.Books.ToList();
        }


        public Book GetBookById(long id)
        {
            return this.cc.Books.Find(id);
        }

    }
}
