/*Name:    Jeremy Brown
  Date:    12/2/2011
  Class:   CIS 199-01
  Purpose: The purpose of this program is to build a class that will be used to get, and change
         the properties of the test books that may be held in a library.  We are also to design the 
         class in such a way that is can be used by GUI, Mobile, Console Apps, etc.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    class Program
    {
        // Precondition: None 
        // Postcondition: The LibraryBook Class has been tested
        static void Main(string[] args)
        {
            LibraryBook testBook1 = new LibraryBook("C#", "Prof. Wright", "UofL", 1990, "111");//1st test book
            LibraryBook testBook2 = new LibraryBook("C++", "Dr. Meyer", "UofZ", 200, "999");//2nd test book
            LibraryBook testBook3 = new LibraryBook("Calculus", "Prof. Capone", "Chicago.Inc", 1930, "777");//3rd test book
            LibraryBook testBook4 = new LibraryBook("CCNA", "Prof. Brown", "Cisco", 2007, "875");//4th test book
            LibraryBook testBook5 = new LibraryBook("XHTML", "Prof. Smith", "Microsoft", 2009, "222");//5th test book
            LibraryBook[] bookArray = {testBook1, testBook2,testBook3, testBook4, testBook5};//Array the holds all of the book object
           
            //For loop that displays a row of stars followed by each book objects list of data
            for (int i = 0; i <= bookArray.Length - 1; i++)
            {
                DisplayWithBorder(bookArray[i].returnTitle);//Sets up a row of start before the title of the book 
                Console.WriteLine(bookArray[i]);//Grabs the information from the object in the array, and runs it through the LibraryBook class
                DisplayWithBorder(bookArray[i].returnCallnumber);//Sets up a row of stars after the call number of the book
                Console.WriteLine("\n");
            }
            //Makes sure the set properties work, and the checkedOut Method works
             testBook1.CheckOut();
             testBook4.CheckOut();
             testBook5.CheckOut();
             testBook2.returnCallnumber = "555";
             testBook3.returnCallnumber = "987";
             testBook4.returnPublisher = "CSO";

            //For loop that displays a row of stars followed by each book objects list of data
             for (int i = 0; i <= bookArray.Length - 1; i++)
             {
                 DisplayWithBorder(bookArray[i].returnTitle);
                 Console.WriteLine(bookArray[i]);
                 DisplayWithBorder(bookArray[i].returnCallnumber);
                 Console.WriteLine("\n");
             }
             //Returns the books that were checkedout back to the shelf
             testBook1.ReturnToShelf();
             testBook4.ReturnToShelf();
             testBook5.ReturnToShelf();
             
            
            //For loop that displays a row of stars followed by each book objects list of data
             for (int i = 0; i <= bookArray.Length - 1; i++)
             {
                 DisplayWithBorder(bookArray[i].returnTitle);
                 Console.WriteLine(bookArray[i]);
                 DisplayWithBorder(bookArray[i].returnCallnumber);
                 Console.WriteLine("\n");
             }


        }

        // Precondition: None 
        // Postcondition: The DisplayWithBorder method will give a row of starts to seperate each object in order to help the user distinguish between each book object
        public static void DisplayWithBorder(string bookProperty )
        {
            const int EXTRA_SPACE = 4;//Const the contains the length to add on to each set of rows
            const string STAR = "*";//Const that contains the * symbol
            const int AVG = 20;// average length of each length of string introducing each property of the library book objects.  The books title is....etc
            int Size = bookProperty.Length + EXTRA_SPACE + AVG;//Contains the size of stars needed to be used
            //For loop that displays a row of stars followed by each book objects list of data
            for (int x = 0; x <= Size; x++ )
                Console.Write(STAR);
            Console.WriteLine();
           
        }
    }
}
