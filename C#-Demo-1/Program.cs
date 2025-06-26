namespace C__Demo_1
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Print();

            int X = 10;
            int Y = 0;
            Console.WriteLine(X/Y);    //  Error 


            /* Multiple comment */
            // single line coment 
            // int z = 20 ;

            #region Comments

            // 
            /**/
            #endregion
        }

        /// <summary>
        ///      و معناها بتلخص حاجه معينه  Function دي كومنت عادي بس بتتعنل برا ال 
        /// </summary>
        public static void Print()
        {
            
        }
    }
}
