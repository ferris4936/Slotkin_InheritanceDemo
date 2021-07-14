using System;

namespace Slotkin_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;

            Employee emp2 = hourEmp;


            Console.WriteLine("emp.GetPaySummary: " + emp.PaySummary);
            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.PaySummary);
            Console.WriteLine("emp2.GetPaySummary: " + emp2.PaySummary);
          
        }
    }
}
