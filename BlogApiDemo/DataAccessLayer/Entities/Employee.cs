using System.ComponentModel.DataAnnotations;

namespace BlogApiDemo.DataAccessLayer.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
