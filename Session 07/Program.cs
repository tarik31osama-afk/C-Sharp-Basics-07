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
        }
    }
}
