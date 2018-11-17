 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(40, 40);
            HorizontalLine topLine = new HorizontalLine(1, 40, 1, '_');
            HorizontalLine bottomLine = new HorizontalLine(1, 40, 25, '_');
            topLine.Drow();
            bottomLine.Drow();
            
            VerticalLine leftLine = new VerticalLine(2, 25, 1, '|');
            VerticalLine rightLine = new VerticalLine(2, 25, 40, '|');

            leftLine.Drow();
            rightLine.Drow();

           

            Point p = new Point(5, 4, '*');
            Snake snake = new Snake( p, 5, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(30, 20, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                System.Threading.Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
    
            Console.ReadLine();
        }
    }
}
