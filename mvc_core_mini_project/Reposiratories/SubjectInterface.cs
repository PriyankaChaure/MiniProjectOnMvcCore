using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public interface SubjectInterface
    {
        List<Subject> GetAllSubjects();
        Subject GetSubjectById(Int64 id);
        void Add(Subject rec);
        void Edit (Subject rec);
        void Delete(long id);
        void Details(long id);

    }
}
