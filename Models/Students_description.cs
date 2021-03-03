using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Students_description
    {
        [Key]
        public int id { get; set; }
        public decimal students_id { get; set; }
        public int age { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string country { get; set; }
    }
}