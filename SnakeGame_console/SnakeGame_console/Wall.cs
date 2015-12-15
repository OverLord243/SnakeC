using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_console
{
    class Wall
    {
        List<Figure> wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Рисуем рамку
            HorisontalLine upLine = new HorisontalLine(0, mapWidth - 2, 0, '+');
            HorisontalLine downline = new HorisontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downline);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }


        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
                   


    



    public void Draw()
{
    foreach (var wall in wallList)
{
    wall.Draw();
}
}
}
}

