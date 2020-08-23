using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentno15
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredlist = new List<Employees>();

           var listOfEmployees = new List<Employees>
            {
                new Employees { EmployeeID=1150, FirstName="Jack",LastName="Steven", Salary=5000m, Age=35,Appraisal = new List<int>{7,7,8,9,7} },
                new Employees { EmployeeID=1150, FirstName="Debora",LastName="Watson", Salary=10000m, Age=45,Appraisal = new List<int>{9,9,8,9,8} },
                new Employees { EmployeeID=1150, FirstName="Claire",LastName="Adam", Salary=7500m, Age=32,Appraisal = new List<int>{9,7,8,9,7} },
                new Employees { EmployeeID=1150, FirstName="Michael",LastName="Rob", Salary=3500m, Age=22,Appraisal = new List<int>{6,7,8,7,7} },
                new Employees { EmployeeID=1150, FirstName="Matthew",LastName="Forest", Salary=4500m, Age=28,Appraisal = new List<int>{7,7,6,6,7} },
                new Employees { EmployeeID=1150, FirstName="Charles",LastName="Kris", Salary=8000m, Age=27,Appraisal = new List<int>{8,9,7,8,8} },
                new Employees { EmployeeID=1150, FirstName="Robert",LastName="Wilson", Salary=8000m, Age=28,Appraisal = new List<int>{8,9,8,9,9} },
                new Employees { EmployeeID=1150, FirstName="Emma",LastName="Brooks", Salary=6000m, Age=23,Appraisal = new List<int>{8,6,9,9,7} },
                new Employees { EmployeeID=1150, FirstName="Jennifer",LastName="Blake", Salary=3000m, Age=38,Appraisal = new List<int>{6,7,7,6,6} },
                new Employees { EmployeeID=1150, FirstName="Terry",LastName="Loyd", Salary=9000m, Age=49,Appraisal = new List<int>{9,9,9,8,7} },
                new Employees { EmployeeID=1150, FirstName="Adam",LastName="Spencer", Salary=7000m, Age=33,Appraisal = new List<int>{8,8,8,6,7} },
                new Employees { EmployeeID=1150, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} }
            };


            // Employees.display(listOfEmployees);
           


            Employees.diplaywithempapp(listOfEmployees, "all employees details ");
            //querry
            //filteredlist = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40).ToList();
            //filteredlist = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40 || e.Salary >= 8000).ToList();
            //filteredlist = listOfEmployees.Where(e => e.Salary > 4000 && e.Appraisal[0] < 8).ToList();

            //foreach (var employee in listOfEmployees)
            //{
            //    if (employee.Salary>=6000 && employee.Age>=40)
            //        Console.WriteLine(employee.FirstName);
            //}
            //Console.WriteLine();
            //foreach (var employee in filteredlist)
            //{
            //    Console.WriteLine(employee.FirstName);
            //}
            //LINQ querry syntax
            //filteredlist = (from emp in listOfEmployees
            //                where emp.Salary > 4000 && emp.Appraisal[0] < 8
            //                select emp).ToList();
            //Employees.diplaywithempapp(filteredlist, "s>4000 and app<8");
            // employee list in ascending salary order

            filteredlist = (from emp in listOfEmployees
                            orderby emp.Age descending, emp.Appraisal[0] descending
                            select emp).ToList();
            Employees.diplaywithempapp(filteredlist, " salary in order");


        }
    }

    class Employees
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;
        private List<int> appraisal;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<int> Appraisal
        {
            get { return appraisal; }
            set { appraisal = value; }
        }

        public static void display(List<Employees> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName}, {employee.LastName}, {employee.Salary},{employee.Age},last 5 appraisals |");

            }
            Console.WriteLine("\n-----------------\n");

        }

        public static void diplaywithempapp(List<Employees> employees, string message)
        {
            if(message!=null)
            {
                Console.WriteLine(message);
                Console.WriteLine("----------------------------------------------");
            }

            foreach (var employee in employees)
            {
                Console.Write($"{employee.FirstName}, {employee.LastName}, {employee.Salary},{employee.Age},last 5 appraisals |");

                foreach (var app in employee.Appraisal)
                {
                    Console.Write(app + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

        }

    }
}
 