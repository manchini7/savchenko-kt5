using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSplitFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hm = new Human("John", "Johnson", false);
            hm.Print();
            Citizen ct = new Citizen("Petr", "Petrenko", false, "A101ksdl233", "New City");
            Console.WriteLine("------------------------");
            ct.Print(); // вывести значение полей класса 
            ForeignCitizen fc = new ForeignCitizen("Ivanov", "Ivan", false, "0230902ADK", "London", "023329032JJK", Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2085"));
            Console.WriteLine("------------------");
            fc.Print();
        }

    }
}
        