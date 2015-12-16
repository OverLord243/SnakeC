using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_console
{
    class Gun:Figure
    {
        public Point point;
        public Direction direction;
        public void Guns(Point tail, Direction direction)
        {
            
               
                //direction = Snake Direction
              

             //   Snake gun = new Snake(Program.CurrentPoint, 1, Program.CurrentSnake.direction);

        
        }

             internal void MoveGun()
        {
            Point tail=pList.First();
            pList.Remove(tail);
            Point head =GetNextPoint();
            pList.Add( head );

            tail.Clear();
            head.Draw();
        }



          private Point GetNextPoint()
        {
            Console.ForegroundColor = ConsoleColor.Green;
    Point head = pList.Last();
            Point nextPoint = new Point( head );
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}

