///Write a program in C# Sharp to insert the information of two books. 

///Test Data :

///Insert the information of two books :                    
///-----------------------------------------
////Information of book 1 :                                  
/////Input name of the book : BASIC
////Input the author : S.TROELSTRA

///Information of book 2 :                                  
///Input name of the book : C +
///Input the author : G.RTRTG
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
	struct book
	{
		public string title;
		public string author;
	}
	 class STructEg3
	{
		public static void Main()
		{
			int nobook = 1000;
			book[] books = new book[nobook];
			int i, j, n = 1, k = 1;
			Console.Write("\n Insert the information of two books :\n");
			Console.Write("-----------------------------------------\n");
			for (j = 0; j <= n; j++)
			{
				Console.WriteLine("Information of book {0} :", k);

				Console.Write("ENter the  name of the book : ");
				books[j].title = Console.ReadLine();

				Console.Write("ENter the name of the author : ");
				books[j].author = Console.ReadLine();
				k++;
				Console.WriteLine();
			}

			for (i = 0; i <= n; i++)
			{
				Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
				Console.WriteLine();
			}

		}
	 }


}



//output:
//Insert the information of two books :                    
//-----------------------------------------
//Information of book 1 :                                  

//Enter the name of the book : BASIC

//Enter the name of the author : S.TROELSTRA

//Information of book 2 :  
                                
//Enter the name of the book : C +

//Enter the name of the author : G.RTRTG

//1: Title = BASIC,  Author = S.TROELST
//2: Title = C +,  Author = G.RTRTG
