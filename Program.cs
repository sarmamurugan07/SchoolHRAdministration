using System;
using MyAspNetCoreApp.HRAdministraction;
using System.Linq;

namespace ConsoleApp
{
    class SchoolHRAdministration
    {
        public enum EmployeeType
        {
            Teacher,
            HeadOfDeparment,
            DeputyHeadMaster,
            HeadMaster
        }
        public class EmployeeFactory
        {
         public static IEmpoyee GetEmployeeInstance(EmployeeType employeeType,int id,string fristName ,string lastName,decimal salary)
         {
            IEmpoyee employee =null;
            switch(employeeType)
            {
                case EmployeeType.Teacher:
                employee = FactoryPettern<IEmpoyee,Teacher>.GetInstance();
                break;
                case EmployeeType.HeadOfDeparment:
                employee =FactoryPettern<IEmpoyee,HeadOfDepartment>.GetInstance();
                break;
                case EmployeeType.DeputyHeadMaster:
                employee = FactoryPettern<IEmpoyee,DeputyHeadMaster>.GetInstance();
                break;
                case EmployeeType.HeadMaster:
                employee= FactoryPettern<IEmpoyee,HeadMaster>.GetInstance();
                break;
                default:
                break;
            }
            if(employee!=null)
            {
                employee.Id=id;
                employee.FristName = fristName;
                employee.LastName = lastName;
                employee.Salary = salary;
            }
            else
            {
                throw  new NullReferenceException();
            }
            return employee;
         }

        }
        static void Main(string[] args)
        {
           
           decimal totalSalaries =0;
           List<IEmpoyee> employees = new List<IEmpoyee>();
           SetData(employees);
            Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e=>e.Salary)}");
        }
        public static void SetData(List<IEmpoyee> employees)
        {
          IEmpoyee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", 4000);
          employees.Add(teacher1);
          IEmpoyee HeadOfDeparment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDeparment, 2,"Fisher","Fisher",4000);
          employees.Add(HeadOfDeparment);
          IEmpoyee DeptyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 3,"ram","Fisher",6000);
          employees.Add(DeptyHeadMaster);
         IEmpoyee HeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 4,"sharma","Fisher",6000);
           employees.Add(DeptyHeadMaster);
        }
    }
        public class Teacher:EmployeeBase
        {
        public override decimal Salary { get => base.Salary+(base.Salary*02m); }
       }
        public class HeadOfDepartment:EmployeeBase
        {
            public override decimal Salary { get => base.Salary+(base.Salary*03m); }
        }
        public class DeputyHeadMaster:EmployeeBase
        {
             public override decimal Salary { get => base.Salary+(base.Salary*04m); }
        }
        public class HeadMaster:EmployeeBase
        {
             public override decimal Salary { get => base.Salary+(base.Salary*04m); }
        }
       
}
