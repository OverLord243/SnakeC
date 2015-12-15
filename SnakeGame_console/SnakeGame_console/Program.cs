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
                Point p = new Point(24, 10, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                FoodCreator foodCreate = new FoodCreator(78, 24, '%');
                Point food = foodCreate.CreateFood();
                food.Draw();
                Point food2 = foodCreate.CreateFood();
                food2.Draw();










                while (true)
                {

                    if (snake.Eat(food))
                    { food=foodCreate.CreateFood();
                        food.Draw();
                    }
                        else if   (snake.Eat(food2))
                    { food2=foodCreate.CreateFood();
                        food2.Draw();
                    }
                        else
                        {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.KeyPressi(key.Key);
                    }
                Thread.Sleep(100); // задержка между циклами(скорость змейки)
                snake.Move();
                }
                }
            


            Console.ReadLine();
        }


   
    }
}
