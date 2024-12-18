using System.ComponentModel.DataAnnotations;

namespace RT.Model
{
    public class Supervisor
    {
        [Key] public int Supervisor_Id { get; set; }
        public string Gender { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Phone_Number { get; set; }
        public string? Email { get; set; }
    }
}
