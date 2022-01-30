//Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.Test The functionalities.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    interface IStudent
    {
        void ShowDetails(int id, string name);
    }
    class DaySholar : IStudent
    {
        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("Student Id is:{0}\nName of the student is:{1}", id, name);
        }
    }
    class Resident : IStudent
    {
        public void ShowDetails(int id,string name)
        {
            Console.WriteLine("Student id is:{0}\n Name of the Student is{1}",id,name);
        }
    }
    class InterfaeEg
    {
        static void Main()
        {
            Console.WriteLine("*****Dayscholar Details****");
            IStudent d = new DaySholar();
            d.ShowDetails(1, "Jyothi");

            Console.WriteLine("*****Resident Scholar Details****");
            IStudent r = new Resident();
            r.ShowDetails(2, "Krishna");

        }
    }
}
