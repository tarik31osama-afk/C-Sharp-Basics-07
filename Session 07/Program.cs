namespace Session_07
{
    internal class Program
    {
        

        
        static void Main(string[] args)
        {  
            #region 1st q

            Book book=new Book();

            //Console.WriteLine(book.Password);
            /* the program will not run because the field password  is private so  can't use it out side the class */

            #endregion

            #region 2nd q
            Console.WriteLine(book.copiesInStock);
            /* it will compile because the field is internal so it can be used in all project*/


            #endregion

            #region 3rd q
            book.title = "clean code";
            Console.WriteLine(book.title);
            #endregion

            #region 4th q

            book.genre = Genre.Science;
            Console.WriteLine(book.genre);

            #endregion

            #region 5th q

            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int) Genre.Science);

            #endregion

            #region 6th
            int genreNumber = 1;
            book.genre = (Genre)genreNumber;
            Console.WriteLine(book.genre);

            #endregion
        }
    }
}
