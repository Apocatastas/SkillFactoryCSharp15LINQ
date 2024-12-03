﻿using System;
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

            var depsWithEmployees = departments.GroupJoin(
                                                           employees,
                                                           d => d.Id,
                                                           e => e.DepartmentId,
                                                           (d, emps) => new 
                                                           {
                                                               Name = d.Name,
                                                               Employees = emps.Select(e => e.Name)
                                                           });
            foreach (var dep in depsWithEmployees)
            {
                Console.WriteLine(dep.Name + ":");
                foreach (string emp in dep.Employees)
                    Console.WriteLine(emp);
            }
                Console.ReadKey();
        }
    }
}



