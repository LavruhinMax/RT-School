using System.ComponentModel.DataAnnotations;

namespace RT.Model
{
    public class Course
    {
        [Key] public int Course_Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }

    }
}
