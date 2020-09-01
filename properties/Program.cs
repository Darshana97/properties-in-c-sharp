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

        public void SetName(string FirstName)
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._FirstName = FirstName;
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(this._FirstName))
            {
                return "No name";
            }
            else
            {
                return this._FirstName;
            }
             
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Students S1 = new Students();
            S1.SetId(100);
            Console.WriteLine("Student id is {0}", S1.GetId());

            S1.SetName("");
            Console.WriteLine("My name is {0}",S1.GetName());
            Console.ReadLine();


            /*S1._Id = 100;
            S1._FirstName = "Darshana";
            S1._LastName = "Senevirathna";

            Console.WriteLine("My id is = {0}, i'm {1} {2}", S1._Id,S1._FirstName,S1._LastName);
            Console.ReadLine();*/

        }
    }
}
