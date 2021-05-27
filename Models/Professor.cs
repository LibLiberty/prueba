using System.Collections.Generic;
namespace prueba.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Course { get; set; }
        public virtual ICollection<Teach> Teaches { get; set; }
    }
    
}