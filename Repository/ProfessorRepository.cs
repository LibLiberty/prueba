using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prueba.Data;
using prueba.Models;
using prueba.Repository.Interfaces;

namespace prueba.Repository
{
    public class ProfessorRepository: IProfessorRepository
    {
        private readonly DataContext _context;
        public ProfessorRepository(DataContext context){
            _context=context;
        }
        public async Task<List<Professor>> ProfessorList(){
            var list = await _context.Professors.ToListAsync();
            return list;




        }
    }
}