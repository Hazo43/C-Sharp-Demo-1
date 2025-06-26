using System.Net;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine(X / Y);    //  Error 


            /* Multiple comment */
            // single line coment 
            // int z = 20 ;

            #region Comments

            // 
            /**/
            #endregion

            Person person = new Person();
            WeekDays weekDays = WeekDays.Saturday;
            
            Int32 t = 0 ;   // = int 
            t = 5;

            //int t; // Declarition
            //t = 3;  // intialization 
            //int 3t = 2; // error
            //int string = 5;// error 
            //Console.WriteLine(t);

            public WeekDays weekDays { get; set; }
        public HttpStatusCode mypropaplyty { get; set; }    

        

        /// <summary>
        ///      و معناها بتلخص حاجه معينه  Function دي كومنت عادي بس بتتعمل برا ال 
        /// </summary>
        public static void Print()
        {
            
        }

        public enum WeekDays
        {
            Saturday = 1,   // defult start 0
            sunday,

        }
    }
}
