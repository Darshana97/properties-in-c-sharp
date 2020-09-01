using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{

    class Students
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student id cannot be negative");
            }
            this._Id = Id;
        }

        public int GetId()
        {
            return this._Id;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Students S1 = new Students();
            S1.SetId(-100);

            
            /*S1._Id = 100;
            S1._FirstName = "Darshana";
            S1._LastName = "Senevirathna";

            Console.WriteLine("My id is = {0}, i'm {1} {2}", S1._Id,S1._FirstName,S1._LastName);
            Console.ReadLine();*/

        }
    }
}
