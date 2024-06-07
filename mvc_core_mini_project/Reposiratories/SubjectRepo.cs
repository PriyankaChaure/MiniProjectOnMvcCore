using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public class SubjectRepo : SubjectInterface
    {
        CompanyContext cc;
        public SubjectRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Subject rec)
        {
            this.cc.Subjects.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Subjects.Find(id);
            this.cc.Subjects.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Details(long id)
        {
            var rec = this.cc.Subjects.Find(id);
        }

        public void Edit(Subject rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Subject> GetAllSubjects()
        {
            return this.cc.Subjects.ToList();
        }

        public Subject GetSubjectById(Int64 id)
        {
            return this.cc.Subjects.Find(id);
        }
    }
}
