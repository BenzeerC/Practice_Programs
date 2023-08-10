using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }



        static void IncreaseSalary(List<Employee> list)
        {
            foreach(Employee item in list)
            {
                if(item.Salary > 20000)
                {
                    item.Salary = (item.Salary + item.Salary * 0.10);
                    Console.WriteLine(item.Id+" "+item.Name+" "+item.Salary);

                }
            }
        }

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Dictionary<double,List<string>> employee= new Dictionary<double,List<string>>();

            list.Add(new Employee() { Id = 101, Name = "Seema", Salary = 25000 });
            list.Add(new Employee() { Id = 102, Name="Pallavi", Salary = 30000 });
            list.Add(new Employee() { Id = 103, Name = "Anil", Salary = 20000 });
            list.Add(new Employee() { Id = 104, Name = "Shital", Salary = 18000 });
            list.Add(new Employee() { Id = 105, Name = "Raju", Salary = 20000 });
            list.Add(new Employee() { Id = 106, Name = "Sunita", Salary = 20000 });
            list.Add(new Employee() { Id = 107, Name = "Pragati", Salary = 20000 });
            foreach (var item in list)
            {
                if(!employee.ContainsKey(item.Salary))
                {
                    employee[item.Salary] = new List<string>();
                }
                employee[item.Salary].Add(item.Name);
            }
            Console.WriteLine("Employee with same salary\n");
            foreach (var item in employee)
            {
                if(item.Value.Count>1)
                {
                    Console.WriteLine($"Salary:{item.Key}: {string.Join(", ",item.Value)}");
                }
            }
            Console.WriteLine();
            IncreaseSalary(list);
        }
    }
}
