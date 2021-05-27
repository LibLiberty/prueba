using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Data;
using prueba.Models;
using prueba.Repository.Interfaces;

namespace prueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<Professor> _logger;
        private readonly DataContext _context;
        private readonly IProfesorRepository _profRep;
        public TeacherController(ILogger<Professor> logger, DataContext context, IProfesorRepository profRep)
        {
            _logger = logger;
            _context = context;
            _profRep = profRep;
        }

        [HttpGet("{getProfesor}")]
        public async Task<IActionResult> GetProfessors()
        {
            try
            {

                var profget = await _profRep.GetUser();
                if (profget == null)
                {
                    return NoContent();
                }

                return Ok(profget);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("Error");

            }
        }
    }
}
