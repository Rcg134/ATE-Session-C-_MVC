using Activity_11_04_23;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Activity_04_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Query syntax
            //int[] number = { 23, 46, 45, 36, 34, 67 };


            //var getNumberGreaterThan45 = from inum in number
            //                where (inum >= 45 || inum == 23)
            //                select inum;

            ////Method syntax
            //int sum = number.Sum(x => x);
            ////Method Syntax
            //var getNumberMethondsyntax = number
            //    .Where(inumber => inumber >= 45 || inumber == 23);

            //foreach (var getnum in getNumberMethondsyntax)
            //{
            //    Console.WriteLine(getnum);
            //}


            //Console.WriteLine(getNumberMethondsyntax);

            //List<Customer> customerLists = new List<Customer>()
            //{
            //    new Customer() {Id = 1 , Name="Duterte", Surname ="Sibayan" },
            //     new Customer() {Id = 2 , Name="Sarah", Surname ="Somehting" },
            //      new Customer() {Id = 3 , Name="Tine", Surname ="Tionco" }
            //};

            //List<Order> orderLists = new List<Order>()
            //{
            //     new Order() {Id = 1, CustomerID = 1 , product = "Sting" , description = "Pampalakas" },
            //     new Order() {Id = 2, CustomerID = 2 , product = "Cola" , description = "Pampabato" },
            //     new Order() {Id = 3, CustomerID = 3 , product = "Spider Man 2" , description = "Pampalibang" }
            //};


            //var queries = from customer in customerLists
            //              join orderlist in orderLists on customer.Id equals orderlist.CustomerID
            //              select new
            //              {
            //                  Name = $"{customer.Name}  {customer.Surname}",
            //                  Product = $"{orderlist.product} {orderlist.description}"
            //              };


            //// string interpolation
            //foreach (var query in queries)
            //{
            //    Console.WriteLine($"Name :{query.Name} , Item :{query.Product}");
            //}
            //List<Employee> employeeList = new List<Employee>()
            //{
            //    new Employee() { ID = 1, FirstName = "Justine", LastName = "Oruga", DeptID = 1 },
            //    new Employee() { ID = 2, FirstName = "Francis", LastName = "Tiongco", DeptID = 2 }
            //};

            //List<Department> departmentList = new List<Department>();
            //{
            //    new Department() { ID = 1, Name = "IT", Description = "Developer" };
            //    new Department() { ID = 2, Name = "IT", Description = "Technical" };
            //};

            //foreach (var emp in employeeList)
            //{
            //      Console.WriteLine(emp);
            //}

            //var getEmpListQuery = from dept in departmentList
            //                      join emp in employeeList on dept.ID equals emp.DeptID
            //                      select new
            //                      {
            //                          EmployeeName = $"{emp.FirstName} {emp.LastName}",
            //                          DepartmentName = $"{dept.Name} - {dept.Description}"
            //                      };


            //ternary operator
            //int x = 1;

            //var result = x == 1 ? "equal 1" : "Not equal 1";

            //Console.WriteLine(result);

            //Coalescing operator
            //int? y = 22;
            //int i = y ?? 10;
            //Console.WriteLine(i);

            //string[] list= { "ADN", "AMB", "NBA" };
            //string joinText = string.Join(" ", list);

            //Console.WriteLine(joinText);


            //if (x == 1)
            //{
            //    Console.WriteLine("equal 1");
            //}
            //else { Console.WriteLine("Not equal 1"); }
            Console.WriteLine(sample.isitTrue(false));
  

        }

        class sample
        {
            public static Boolean isitTrue(Boolean istrue) { 
                if (istrue == true) { 
                    return true;
                }
                else {   return false; }
             
            }

        }
    }
}
