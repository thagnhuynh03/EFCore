namespace CodeFirst.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public virtual List<Employee> employees { get; set; }
        public int companyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
