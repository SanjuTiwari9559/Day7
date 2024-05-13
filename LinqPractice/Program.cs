using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqPractice
{
    internal class Program
    {
      static   List<Employee> listEmp = new List<Employee>();
      static  List<Department> listDept = new List<Department>();
     public  static void addEmpAndDept()
        {
         
            listEmp.Add(new Employee
            {
                EmpNo = 1,
                Name = "Vikram",
                Basic = 10000,
                DeptNo = 10,
                Gender = "M"
            });
            listEmp.Add(new Employee
            {
                EmpNo = 2,
                Name = "Vikas",
                Basic = 11000,
                DeptNo = 10,
                Gender = "M"
            });
            listEmp.Add(new Employee
            {
                EmpNo = 3,
                Name = "Abhijit",
                Basic = 12000,
                DeptNo = 20,
                Gender = "M"
            });
            listEmp.Add(new Employee
            {
                EmpNo = 4,
                Name = "Mona",
                Basic = 11000,
                DeptNo = 20,
                Gender = "F"
            });
            listDept.Add(new Department
            {
                DeptNo = 10,
                DeptName = "SALES"
            });
            listDept.Add(new Department
            {
                DeptNo = 20,
                DeptName = "MKTG"
            });
            listDept.Add(new Department
            {
                DeptNo = 30,
                DeptName = "IT"
            });
        }
        static void Main1(string[] args)
        {
            addEmpAndDept();
            // var emps=from emp in listEmp select emp;
            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp.Name +" "+emp.EmpNo);
            //}
            var empNo = from emp in listEmp select emp.EmpNo;
            foreach(int empN in empNo)
            {
                Console.WriteLine(empN);
            }
             
            

        }
        static void Main2(string[] args)
        {
            addEmpAndDept();
            var selectedEmp=from emp in listEmp 
                    where emp.EmpNo ==1
                    select emp;
            foreach(var empN in selectedEmp)
            {
                Console.WriteLine($"Employee {empN.Name}  {empN.EmpNo}");
            }
        }
        static void Main(string[] args)
        {
            addEmpAndDept();
            var selectedEmp=from emp in listEmp
                            where emp.EmpNo >1
                            orderby emp.Name ,emp.EmpNo
                            select emp;
            foreach(var empN in selectedEmp)
            {
                Console.WriteLine(empN.Name);
            }
        }
      
    }
}
