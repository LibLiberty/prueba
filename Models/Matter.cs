using System.Collections.Generic;
namespace WonderMath.API.Models
{
    public class Matter
    {

        public int Id { get; set; }
        public virtual Learn Learn { get; set; }
        public int IdLearn { get; set; }
        public virtual Classroom Classroom { get; set; }
        public int IdClassroom { get; set; }
        public string Topic { get; set; }
        public virtual ICollection<Teach> Teach { get; set; }
        public int Notes { get; set; } 
        public string Name {get; set}
    }
}