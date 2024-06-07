using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public interface AuthorInterface
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(Int64 id);
        void Add(Author rec);
        void Edit(Author rec);
        void Delete(long id);
        void Details(long id);
    }
}
