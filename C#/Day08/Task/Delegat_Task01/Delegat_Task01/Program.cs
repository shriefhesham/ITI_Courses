using static Delegat_Task01.LibraryEngine;

namespace Delegat_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("555_318_209", "C#", new string[] { "Shrief", "Nada" }, new DateTime(1999, 3, 10), 5000);
            Book book2 = new Book("555_318_208", "DesignPattern", new string[] { "Hoosam", "Khaled" }, new DateTime(1999, 3, 11), 6000);
            Book book3 = new Book("555_318_207", "C++", new string[] { "Ali", "Yassen" }, new DateTime(1999, 3, 12), 7000);
            List<Book> BookListt = new List<Book> { book1, book2, book3 };




            BookDlgDT fptr;
            fptr =new BookDlgDT(BookFunctions.GetTitle) ;
            LibraryEngine.ProcessBooks(BookListt, fptr);
            Console.WriteLine("----------------------------------------");

            fptr = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(BookListt, fptr);
            Console.WriteLine("----------------------------------------");


            fptr = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(BookListt, fptr);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("------------------------------------------func----------------------------------------");
            Console.WriteLine("funC");
            #region funC
            Func<Book, string> funCptr =new Func<Book, string>( BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(BookListt, funCptr);
            #endregion

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------ Anonymous Method -----------------------------------------------");
            #region Anonymous Method 
            funCptr = delegate (Book b) { return b.ISBN; };
            LibraryEngine.ProcessBooks(BookListt, funCptr);
            #endregion


            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(" --------------------------------Lambda Expression------------------------------------------- ");
           
            #region Lambda Expression 
            funCptr = b =>  b.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(BookListt, funCptr);
            #endregion




        }

    } 
}