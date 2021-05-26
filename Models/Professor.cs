using System.Collections.Generic;
namespace WonderMath.API.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Course { get; set; }
        public virtual Teach Teach { get; set; }
        public int IdTeach { get; set; }
    }
    
}