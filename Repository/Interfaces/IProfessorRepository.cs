using System.Collections.Generic;
using System.Threading.Tasks;
using prueba.Models;

namespace prueba.Repository.Interfaces
{
    public interface IProfessorRepository
    {
         Task<List <Professor>> ProfessorList();
    }
}