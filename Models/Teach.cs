using System.Collections.Generic;
namespace WonderMath.API.Models
{
    public class Teach
    {
        public int Id { get; set; }
        public virtual Matter Matter { get; set; }
        public int IdMatter { get; set; }
    }
}