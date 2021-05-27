using System.Collections.Generic;
using System.Threading.Tasks;
using prueba.Models;

namespace prueba.Repository.Interfaces
{
    public interface IProfesorRepository
    {
        
        Task<List<Professor>> GetUser();
    }
}