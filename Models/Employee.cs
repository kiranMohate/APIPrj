using System;
using System.Collections.Generic;

namespace FirstApi.Models
{
    public partial class Employee
    {
        public int Empid { get; set; }
        public string? Empname { get; set; }
        public double? Salary { get; set; }
        public DateTime? Doj { get; set; }
    }
}
