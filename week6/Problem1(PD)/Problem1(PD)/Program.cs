using Problem1_PD_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem1_PD_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "maze.txt";
            Grid mazeGrid = new Grid(24, 71, path);
            Pacman player = new Pacman(9, 32, mazeGrid);
            Ghost ghost1 = new Ghost(15, 39, "left", 'H', 0.1F, ' ', mazeGrid);
            Ghost ghost2 = new Ghost(20, 57, "up", 'V', 0.2F, ' ', mazeGrid);
            Ghost ghost3 = new Ghost(19, 26, "up", 'H', 1F, ' ', mazeGrid);
            Ghost ghost4 = new Ghost(18, 21, "up", 'H', 0.5F, ' ', mazeGrid);

            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(ghost1);
            enemies.Add(ghost2);
            enemies.Add(ghost3);
            enemies.Add(ghost4);

            mazeGrid.Draw();
            player.Print(9, 32);
            bool gameRunning = true;

            while (gameRunning)
            {
                Thread.Sleep(90);

                player.PrintScore();
                player.Remove(9, 32);
                player.Move();
                player.Print(10, 33);

                foreach (Ghost g in enemies)
                {
                    g.Remove(15, 39);
                    g.move();
                    g.Print(16, 40);
                }
            }
            Console.ReadKey();
        }
    }
}
