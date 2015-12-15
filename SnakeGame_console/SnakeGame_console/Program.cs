using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame_console
{
    class Program
    {
        static void Main(string[] args)
        {  //Делаем размер окошка, и чтоб он не растягивался
            Console.SetBufferSize(80, 25);
          
       
              

            //Рисуем стенки-рамки
                HorisontalLine upline = new HorisontalLine(0,78,0,'+');
                upline.Draw();
                HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
                downline.Draw();
                VerticalLine vline = new VerticalLine(0, 24, 0, '+');
                vline.Draw();
                VerticalLine vline2 = new VerticalLine(0, 24, 78, '+');
                vline2.Draw();
            

            
            //Рисуем еще какие то решетки(наверное будут препятствия)
                Point p2 = new Point(4, 5, '#');
                p2.Draw();
                Point p3 = new Point(9, 9, '#');
                p3.Draw();
//Рисуем точки(змейку)
                Point p = new Point(10, 16, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.KeyPressi(key.Key);
                    }
                Thread.Sleep(100); // задержка между циклами(скорость змейки)
                snake.Move();
                }
                
            


            Console.ReadLine();
        }


   
    }
}
