using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public interface BookInterface
    {
        List<Book> GetAllBooks();
        Book GetBookById(Int64 id);
        void Add(Book rec);
        void Edit(Book rec);
        void Delete(long id);
        void Details(long id);
    }
}
