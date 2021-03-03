using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string grade { get; set; }
    }
}