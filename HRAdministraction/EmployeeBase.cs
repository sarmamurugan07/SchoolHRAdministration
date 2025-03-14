using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.HRAdministraction
{
    public class EmployeeBase : IEmpoyee
    {
        public int Id { get; set ; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public virtual decimal Salary { get; set; }
    }
}