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
            HorizontalLine topLine = new HorizontalLine(1, 30, 1, '_');
            HorizontalLine bottomLine = new HorizontalLine(1, 30, 20, '_');
            topLine.Drow();
            bottomLine.Drow();
            
            VerticalLine leftLine = new VerticalLine(2, 20, 1, '|');
            VerticalLine rightLine = new VerticalLine(2, 20, 30, '|');

            leftLine.Drow();
            rightLine.Drow();

            Console.ReadLine();

       
        }
    }
}
