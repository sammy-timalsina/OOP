using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.SingleResponsibility
{
    public class BookService
    {
        public void FindBook(string book)
        {
            Book b = new Book();
            b.BookName = "Ramayan";
            bool x= b.findByBookName(book);
        }
    }
}
