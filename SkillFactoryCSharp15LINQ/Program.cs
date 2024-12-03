using System;
using System.Linq;

namespace SkillFactoryCSharp15LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var employeeAndDep = from employee in employees
                                 join dep in departments on employee.DepartmentId equals dep.Id
                                 select new
                                 {
                                     EmployeeName = employee.Name,
                                     DepartmentName = dep.Name
                                 };

            foreach (var item in employeeAndDep)
                Console.WriteLine(item.EmployeeName + ", отдел: " + item.DepartmentName);
            Console.ReadKey();
        }
    }
}



