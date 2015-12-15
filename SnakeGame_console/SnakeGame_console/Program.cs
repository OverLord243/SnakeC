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
              /*  HorisontalLine upline = new HorisontalLine(0,78,0,'-');
                upline.Draw();
                HorisontalLine downline = new HorisontalLine(0, 78, 24, '-');
                downline.Draw();
                VerticalLine vline = new VerticalLine(0, 24, 0, '|');
                vline.Draw();
                VerticalLine vline2 = new VerticalLine(0, 24, 78, '|');
                vline2.Draw();
               * 
               * 
               * OLD CODE
            */
            //Новые стенки-препятсвия вокруг окна
            Wall walls = new Wall(80, 25);
            walls.Draw();
            //Рисуем препятствия
                HorisontalLine vall1 = new HorisontalLine(20, 27, 18, '_');
                vall1.Draw();

            
            
          
//Рисуем точки(змейку)
                Console.ForegroundColor = ConsoleColor.Green;
                Point p = new Point(24, 10, '*');
                
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                
                snake.Draw();
//Рисуем еду змейке)
                FoodCreator foodCreate = new FoodCreator(78, 24, '%');
                Point food = foodCreate.CreateFood();
                Console.ForegroundColor = ConsoleColor.Green;
                food.Draw();

               

                Point food2 = foodCreate.CreateFood();
                food2.Draw();









//Проверяем на столкновения
                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail()) //если врезался в стенку или свой хвост брякнуть прогу.
                    {
                        break;
                    }

                    
                    if (snake.Eat(food))
                    { food=foodCreate.CreateFood();
                
                        food.Draw();     
                    }
                        else if   (snake.Eat(food2))
                    { food2=foodCreate.CreateFood();
                    food = foodCreate.CreateFood();
                   
                        food2.Draw();
                    }
                        else
                        {
                    if (Console.KeyAvailable) //Тут змейка принимает нажатую клавишу и поворачивает
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
