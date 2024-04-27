using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Markshhet_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marksheet");

            Console.WriteLine("Enter Your Name");
            string Studentname = Console.ReadLine();

            Console.WriteLine("Enter Your Rollnumber");
            int Studentroll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Html Marks");
            int Html = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Css Marks");
            int Css = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Javascript Marks");
            int Javascript = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Git Marks");
            int Git = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your PHP Marks");
            int PHP = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Laravel Marks");
            int Laravel = int.Parse(Console.ReadLine());

            int Obtainedmarks = Html + Css + Javascript + Git + PHP + Laravel;

            int Totalmarks = 600;

            int Percentage = Obtainedmarks * 100 / Totalmarks;

            Console.WriteLine("Obtained Marks :" + Obtainedmarks);

            Console.WriteLine("Percentage :" + Percentage + "%");

            Console.ReadKey();
        }
    }
}
