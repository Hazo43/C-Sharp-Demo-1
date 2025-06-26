using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace C__Demo_1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // video 2
            Console.WriteLine("Hello, World!");
            Print();

            int X = 10;
            int Y = 0;
            Console.WriteLine(X / Y);    //  Error 


            /* Multiple comment */
            // single line coment 
            // int z = 20 ;

            // video 3
            #region Comments

            // 
            /**/
            #endregion



            // video 6
            //int x = 10;
            //x++;









            // video 5

            Person person = new Person();
            WeekDays weekDays = WeekDays.Saturday;

            //Int32 t = 0 ;   // = int 
            //t = 5;

            // video 4

            //int t; // Declarition
            //t = 3;  // intialization 
            //int 3t = 2; // error
            //int string = 5;// error 
            //Console.WriteLine(t);


            // video 7

            Point point1 = new Point( 10 ,20 ); // becouse instractors
          // point.X = 10;
          //  point.Y = 20;
            Console.WriteLine(point1.X);
            Console.WriteLine(point1.Y);

            Point point2 = new Point( 30 , 50 )
         //  point2.X = Point.X;
         //  point2.Y = Point.Y;

                point2 = point1;
            point2.X = 100;         //    Console.WriteLine(point1.X);       outPut 100
            Console.WriteLine(point2.X);   // 10  becouse point2 = point1
            Console.WriteLine(point2.Y);   // 20  becouse point2 = point1


            // Video 4
            public WeekDays weekDays { get; set; }
        public HttpStatusCode mypropaplyty { get; set; }



        // videp 3

        /// <summary>
        ///      و معناها بتلخص حاجه معينه  Function دي كومنت عادي بس بتتعمل برا ال 
        /// </summary>
        /// 

        // video 2

        public static void Print()

        {

        }

        // video 5
        public enum WeekDays
        {
            Saturday = 1,   // defult start 0
            sunday,

        }
      
    
    }
}
