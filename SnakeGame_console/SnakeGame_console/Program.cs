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
            Point p1 = new Point(1,3,'*');
            p1.Draw();
       
                Point p2 = new Point(4,5,'#');
                p2.Draw();

                Point p3 = new Point(7, 9, '#');
                p3.Draw();


                List<int> numList = new List<int>();
                numList.Add(0);
                numList.Add(1);
                numList.Add(2);

                int x = numList[0];
            int y= numList[1];
            int z=numList[2];



            //  int x1 = 1;
            //   int y1 = 3;
            //    char sym1 = '*';


            //    int x2 = 4;
            //   int y2 = 5;
            //  char sym2 = '#';
            //  Draw(x2, y2, sym2);

 numList.RemoveAt(0);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
           

            Console.ReadLine();
        }

    }
}
