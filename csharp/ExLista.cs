using System;
using System.Collections.Generic;

namespace ExLista {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int qtt = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= qtt; i++) {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increased: ");
            int searchId = int.Parse(Console.ReadLine());   

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else Console.WriteLine("This ID does not exist!");

            Console.WriteLine();

            Console.WriteLine("Update list of employees: ");
            foreach (Employee obj in list) Console.WriteLine(obj);
        }
    }
}

/*
Classe Employee usada

using System;

namespace ExLista {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get;  private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }

        override public string ToString() {
            return Id + ", " + Name + ", " + Salary.ToString("F2");
        }
    }
}
 */