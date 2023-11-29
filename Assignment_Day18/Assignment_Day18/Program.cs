using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day18
{
    internal delegate void GameProbability();
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GameProbability GamePro = new GameProbability(game.Players);
            GamePro();
            Console.ReadKey();
        }
    }
}