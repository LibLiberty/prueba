using System.Collections.Generic;
namespace prueba.Models
{
    public class Estudent
    {
        public int Id { get; set; }
        public virtual Learn Learn { get; set; }
        public int IdLearn { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Course { get; set; }
        public string SecondLastName { get; set; }
        public int Cellphone { get; set; }
        public int Subject { get; set; }
    }
}