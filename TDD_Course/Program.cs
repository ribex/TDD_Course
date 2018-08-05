using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Orange Is The New Black"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("is The New black Orange"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("The neW Black OranGe Is"));

            Console.Read();
        }
    }
}