using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of the class - NO LONGER ALLOWED
            //SportsPerson sp = new SportsPerson(500, 2, 1);

            //factory method instead
            SportsPerson.CreateNewSportsPerson(500, 3, 2);


            Console.ReadLine(); 

        }
    }
}
