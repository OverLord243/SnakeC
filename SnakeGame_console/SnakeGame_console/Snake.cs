using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_console
{
    class Snake :Figure
       
    {
         Direction direction;

        public Snake(Point tail, int lenght, Direction direction)
        {

            pList=new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
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
    

        internal bool IsHitTail()
        {
            var head=pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }


        internal bool Eat (Point food)
        {
            Point head = GetNextPoint();      
            if (head.IsHit(food))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                 
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
        
        public void KeyPressi(ConsoleKey Key)
        {
           
            if (Key == ConsoleKey.LeftArrow)
                this.direction = Direction.LEFT;
            else if (Key == ConsoleKey.RightArrow)
                this.direction = Direction.RIGHT;
            else if (Key == ConsoleKey.DownArrow)
                this.direction = Direction.DOWN;
            else if (Key == ConsoleKey.UpArrow)
                this.direction = Direction.UP;
        }
    }
}
