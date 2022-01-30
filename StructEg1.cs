//Write a program in C# Sharp to declare a structure called Books with a property, a method to display the value of Book_id, and a private field called Book_id (int)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    struct Book
    {
        public string Name;
        private int Book_Id { get; set; }
        
        public int Book_ID
        {
            get { return Book_Id; }
            set { Book_Id = value; }
        }
        public void Display()
        {
            Console.WriteLine("Book id is:{0}",Book_Id);
            Console.WriteLine("Book name is:{1}", Name);
        }

        
    }
    class StructEg1
    {
        static void Main()
        {
            Book b = new Book();
            b.Book_ID = 100;
            b.Name = "Suspicios Partner";
            b.Display();
            Console.ReadLine();
        }
    }
}
