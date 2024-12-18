using System.ComponentModel.DataAnnotations;

namespace RT.Model
{
    public class Objective
    {
        [Key] public int Objective_Id { get; set; }
        public int Employee_Id { get; set; }
        public int Course_Id { get; set; }
        public bool IsObligatory { get; set; }
        public bool IsFinished { get; set; }
    }
}
