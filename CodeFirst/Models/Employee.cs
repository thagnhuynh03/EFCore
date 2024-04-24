namespace CodeFirst.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public bool gender { get; set; }

        public int departmentId { get; set; }

        public virtual Department department { get; set; }


    }
}
