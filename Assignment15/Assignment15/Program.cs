using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> listofemployees = new List<Employees> {
              new Employees {employeeid=1,name="a",lastname="si",age=25,salary=123, appr=new List<int>{1,2,3,4} },
               new Employees {employeeid=2,name="u",lastname="u",age=30,salary=25, appr=new List<int>{8,5,6,1} },
              new Employees {employeeid=1,name="a",lastname="si",age=25,salary=123, appr=new List<int>{1,2,3,4} } };


           


        }


    }

    class Employees
    {

        private int EmployeeID;

        public int employeeid
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        private string LastName;

        public string lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }

        private int Salary;

        public int salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        private int Age;

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        private List<int> Appr;

        public List<int> appr
        {
            get { return Appr; }
            set { Appr = value; }
        }
    }

    
}
