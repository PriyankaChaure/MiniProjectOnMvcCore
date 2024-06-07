using mvc_core_mini_project.Models;

namespace mvc_core_mini_project.Reposiratories
{
    public interface CustsalvmInterface
    {
       
        void Add(custsalVM rec);
        void Edit(custsalVM rec);
        custsalVM GetId(Int64 id);
      
       
    }
}
