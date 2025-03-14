using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.HRAdministraction
{
    public interface IEmpoyee
    {
        int Id {get;set;}
        string FristName{get;set;}
        string LastName{get;set;}
        decimal Salary {get;set;}

    }
}