using System.ComponentModel.DataAnnotations;

namespace RT.Model
{
    public class Account
    {
        [Key] public int Account_Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public int? Employee_Id { get; set; }
        public int? Supervisor_Id { get; set; }
    }
}
