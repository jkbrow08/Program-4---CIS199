/*Name:    Jeremy Brown
  Date:    12/2/2011
  Class:   CIS 199-01
  Purpose: The purpose of this class is that it will be used to get, and change
         the properties of the test books that may be held in a library.  We are also to design the 
         class in such a way that is can be used by GUI, Mobile, Console Apps, etc.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    class LibraryBook
    {
        private string title;//Contains the title of the book
        private string author;//Contains the author of the book
        private string publisher;//Contains the publisher of the book
        private string callNumber;//Contains the call number of the book
        private int cpyrhtYear;//Contains the copyright year of the book
        private bool checkedOut = false;//Contains the checked out status of the book

        // Precondition:   cpyrhtYear >= 0
        // Postcondition: The Library Book has been initialized with the specified
        //                values for title, author, publisher, copyright, and call number.
        public LibraryBook(string curTitle, string curAuthor, string curPublisher, int curCpyrhtYear, string curCallNumber)
        {
            title = curTitle;
            author = curAuthor;
            publisher = curPublisher;
            cpyrhtYear = curCpyrhtYear;
            callNumber = curCallNumber;

        }
        
        public string returnTitle
        {
            // Precondition:  None 
            // Postcondition: The title has been returned
            get
            {
                return title;
            }
        }
        public string returnAuthor
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return author;
            }
        }
        public string returnPublisher
        {
            // Precondition:  None 
            // Postcondition: The publisher has been returned
            get
            {
                return publisher;
            }
            // Precondition:  None 
            // Postcondition: The publisher has been set to the specified value 
            set
            {
                publisher = value;
            }
        }
        public int returnCpyrghYear
        {
            // Precondition:  None 
            // Postcondition: The copyright year has been returned
            get
            {
                return cpyrhtYear;
            }
            // Precondition:  cpyright >= 0 
            // Postcondition: The Copyright year has been set to the specified value
            private set
            {
                if (value >= 0)
                {
                    cpyrhtYear = value;
                }

            }
        }
        public string returnCallnumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return callNumber;
            }
            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                callNumber = value;
            }
        }
        // Precondition:  None  
        // Postcondition: The bool value has been set to true
        public void CheckOut()
        {
            checkedOut = true;
        }
        // Precondition:  None  
        // Postcondition: The bool value has been set to false
        public void ReturnToShelf()
        {
            checkedOut = false;
        }
        // Precondition:  None
        // Postcondition: The bool value will be returned to whomever invokes the method
        public bool IsCheckedOut()
        {
            return checkedOut;
        }
        // Precondition:  None
        // Postcondition: A string is returned the will contain all of the values of the book object, and the checked out status of each book.
        public override string ToString()
        {
            return string.Format("The book title is {0} \nthe author's name is {1} \nthe publisher is {2}" +
             "\nthe book was copyrighted in {3} \nthe call number of the book is {4} \nthe book is {5}", title, author, publisher, cpyrhtYear, callNumber, IsCheckedOut());
        }

    }
}
