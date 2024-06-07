using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public class AuthorRepo:AuthorInterface
    {
        CompanyContext cc;
        public AuthorRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Author rec)
        {
            this.cc.Authors.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Authors.Find(id);
            this.cc.Authors.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Details(long id)
        {
            var rec = this.cc.Authors.Find(id);
        }

        public void Edit(Author rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Author> GetAllAuthors()
        {
            return this.cc.Authors.ToList();
        }

        public Author GetAuthorById(Int64 id)
        {
            return this.cc.Authors.Find(id);
        }
    }
}
