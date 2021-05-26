using System.Collections.Generic;
namespace WonderMath.API.Models
{
    public class Learn
    {
        public int Id { get; set; }
        public string note { get; set; }
         public virtual ICollection<Professor> Professor { get; set; }

    }
}