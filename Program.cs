using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get employee details from user
            Console.WriteLine("Enter employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee gender (M/F): ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter employee salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter employee date of joining (dd/MM/yyyy): ");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine();

            // Display employee details
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Gender: " + gender);
            Console.WriteLine("Employee Salary: " + salary.ToString("C")); // Display salary as currency
            Console.WriteLine("DOJ: " + doj.ToString("dd/MM/yyyy"));

            // Calculate and display tax
            double taxRate = (salary > 90000) ? 0.3 : 0.15;
            double tax = salary * taxRate;
            Console.WriteLine();
            Console.WriteLine("You have to pay: " + tax.ToString("C"));

            Console.ReadLine();
        }
    }
}
