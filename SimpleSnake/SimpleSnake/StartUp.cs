using System;
using System.Collections.Generic;
using SimpleSnake.Core;
using SimpleSnake.GameObjects;

namespace SimpleSnake
{
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();
            //Console.SetCursorPosition(30, 5);
            //Console.WriteLine('*');
            //Point point = new Point(12, 0);
            //point.Draw('*');
            Wall wall = new Wall(70, 20);
            Food food = new FoodDollar(wall);
            food.SetRandomPosition(new Queue<Point>());
            Snake snake = new Snake(wall);
            Engine engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
