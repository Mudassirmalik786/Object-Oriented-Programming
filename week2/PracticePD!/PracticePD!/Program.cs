using PracticePD_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticePD_
{
    class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            //PacMan Coordinates
            Pacman pacman = new Pacman();
            pacman.xPos = 9;
            pacman.yPos = 31;
            bool gameRunning = true;
            while (true)
            {
                Thread.Sleep(90);
                printScore();
                if()
            }
        }
    }
}
