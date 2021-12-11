using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.SingleResponsibility
{
    public class Book
    {
        //A class should have only one reason to change
        private string bookName;
        private string bookAuthor;
        private string text;

        public string BookName
        {
            get => bookName;
            set => bookName = value;
        }
        public bool findByAuthor(string authName)
        {
            return bookAuthor.Contains(authName);
        }
        public bool findByBookName(string bkName)
        {
            return bookName.Contains(bkName);
        }
        //print operation
        //public void printToConsole()
        //{
        //    //This violates the single responsibility principle
        //}
    }
    //better way is to create a new class
    public class BookPrinter
    {
        public void PrintToConsole(string text)
        {

        }
    }
}
