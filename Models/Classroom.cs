using System.Collections.Generic;
namespace WonderMath.API.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Matter> Matter { get; set; }
        //public virtual ICollection<LessonUser> Matters { get; set; }
    }
}