namespace prueba.Models
{
    public class Teach
    {
        public int Id { get; set; }
        public virtual Matter Matter { get; set; }
        public int MatterId { get; set; }
        public virtual Professor Professor { get; set; }
        public int ProfessorId { get; set; }
    }
}