using System;

namespace inherit
{
    class VisitingEmployee
    {
        public string EmpName;
        public int EmpID;
        public int EmpSalary;

        public void setDetail(string name, int id, int salary)
        {
            this.EmpName = name;
            this.EmpID = id;
            this.EmpSalary = salary;

            Console.WriteLine("Employee name ="+ this.EmpName);
            Console.WriteLine("Employee id ="+ this.EmpID);
            Console.WriteLine("Employee salary ="+ this.EmpSalary);
        }

    }

    class Employee : VisitingEmployee   
    {
        public string EmpComp;
        public int discount;

        public void Print(string Com, int dis)
        {
            this.EmpComp = Com;
            this.discount = dis;
        }



    }

        
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sonal = new Employee();
            Sonal.setDetail("Sonal", 1423, 50000);
            Sonal.EmpComp = "Chetu";
            Console.WriteLine("Company name:{0}",Sonal.EmpComp);
            

            Console.ReadLine();

        }
    }
}
