using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofEmployees
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> listofemployees = new List<Employees>()
            {
                new Employees { ID=1150, ename="Jack",  age=35,salary = new List<int>{7,7,8,9,7} },
                new Employees{ID=11,ename="asi",age=22,salary=new List<int>{7,9,10,8,5}}
            };
            

        }
    }

    class Employees
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string Ename;

        public string ename
        {
            get { return Ename; }
            set { Ename = value; }
        }

        private int Age;

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        private List<int> Salary;

        public List<int> salary
        {
            get { return Salary; }
            set { Salary = value; }
        }



    }
}
