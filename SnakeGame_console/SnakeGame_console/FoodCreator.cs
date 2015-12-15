using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_console
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
this.mapWidht=mapWidht;
this.mapHeight=mapHeight;
this.sym=sym;

    }
    

        public Point CreateFood()
        {
            int x = random.Next(78);
            int y = random.Next(24 );
            return new Point(x, y, sym);
        }
        }
        
}

