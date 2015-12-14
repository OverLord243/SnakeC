using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Point p1 = new Point(6,6,'*');
            p1.Draw();
       
                Point p2 = new Point(4,5,'#');
                p2.Draw();

                Point p3 = new Point(7, 9, '#');
                p3.Draw();


                HorisontalLine hline = new HorisontalLine(0,78,0,'+');
                hline.Draw();
                HorisontalLine hline2 = new HorisontalLine(0, 78, 24, '+');
                hline2.Draw();
                VerticalLine vline = new VerticalLine(0, 24, 0, '+');
                vline.Draw();
                VerticalLine vline2 = new VerticalLine(0, 24, 78, '+');
                vline2.Draw();
       
           

            Console.ReadLine();
        }

    }
}
