using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataFirst.Repository.Models;

[Table("Company")]
public partial class Company
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [InverseProperty("Company")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
