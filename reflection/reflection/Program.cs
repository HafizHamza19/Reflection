using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int tx;
            int ty;
            int x;
            int y;
            int x1;
            int y1;
            int x2;
            int y2;
            int x3;
            int y3;
            int x4;
            int y4;
            int result;
            Console.WriteLine("**************************Reflection*******************************");
            Console.WriteLine("Please Enter \n1)For x-Axis\n2)For y-Axis \n3)For Origin");
            ty=Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n\nEnter The Value of x1 :");
            x1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y1 :");
            y1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x2 :");
            x2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y2 :");
            y2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x3 :");
            x3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y3 :");
            y3 = Int16.Parse(Console.ReadLine());
           if(ty==1)
           {
            x = 1 * x1;
            y = -1 * y1;
            Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
            x = 1 * x2;
            y = -1 * y2;
            Console.WriteLine("Second Point is  (" + x + "," + y + ")");
            x = 1 * x3;
            y = -1 * y3;
            Console.WriteLine("Third Point is  (" + x + "," + y + ")");
           }
            else if(ty==2)
            {
                x =-1 * x1;
                y = 1 * y1;
                Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
                x = -1 * x2;
                y = 1 * y2;
                Console.WriteLine("Second Point is  (" + x + "," + y + ")");
                x = -1 * x3;
                y = 1 * y3;
                Console.WriteLine("Third Point is  (" + x + "," + y + ")");
            }
           else if(ty==3)
           {
               x = -1 * x1;
               y = -1 * y1;
               Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
               x = -1 * x2;
               y = -1 * y2;
               Console.WriteLine("Second Point is  (" + x + "," + y + ")");
               x = -1 * x3;
               y = -1 * y3;
               Console.WriteLine("Third Point is  (" + x + "," + y + ")");
           }
            Console.ReadLine();
        }
    }
}
