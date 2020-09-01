using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{

    class Students
    {
        public int _Id;
        public string _FirstName;
        public string _LastName;

        public void SetId()
        {

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Students S1 = new Students();
            S1._Id = 100;
            S1._FirstName = "Darshana";
            S1._LastName = "Senevirathna";

            Console.WriteLine("My id is = {0}, i'm {1} {2}", S1._Id,S1._FirstName,S1._LastName);
            Console.ReadLine();

        }
    }
}
