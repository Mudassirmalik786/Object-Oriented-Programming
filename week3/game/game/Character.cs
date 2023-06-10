using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Character
    {
        public char[,] representation;
        public int x;
        public int y;

        public Character()
        {
            x = 4;
            y = 4;
        }
        public Character(char[,] representation, int x, int y)
        {
            this.representation = representation;
            this.x = x;
            this.y = y;
        }
        public void DrawInMaze(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (i >= y && i < y + representation.GetLength(0) && j >= x && j < x + representation.GetLength(1))
                    {
                        Console.Write(representation[i - y, j - x]);
                    }
                    else
                    {
                        Console.Write(maze[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public void erasePlayerFromMaze()
        {

            for (int row = 0; row < 5; row++)
            {
                Console.SetCursorPosition(x + row, y);
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(" ");
                }
            }
        }
        public void movePlayerRight(char[,] maze)
        {

            if (maze[x, y + 5] == ' ' || maze[x, y + 5] == '.')
            {
                erasePlayerFromMaze();
                 Console.SetCursorPosition(y, x);                
                 erasePlayer();
                y = y + 1;
                Console.SetCursorPosition(y, x);
                printPlayerInMaze(maze);
                printMaze(maze);
            }
        }
        public void movePlayerLeft(char[,] maze)
        {
            if (maze[x, y - 1] == ' ' || maze[x, y - 1] == '.')
            {
                erasePlayerFromMaze();
                Console.SetCursorPosition(y, x);
                erasePlayer();
                y = y - 1;
                Console.SetCursorPosition(y, x);
                printPlayerInMaze(maze);
                printMaze(maze);
            }
        }
        public void movePlayerUp(char[,] maze)
        {
            if (maze[x - 1, y] == ' ' || maze[x - 1, y] == '.')
            {
                erasePlayerFromMaze();
                Console.SetCursorPosition(y, x);
                erasePlayer();
                x = x - 1;
                Console.SetCursorPosition(y, x);
                printPlayerInMaze(maze);
                printMaze(maze);
            }
        }
        public void movePlayerDown(char[,] maze)
        {
            if (maze[x + 1, y] == ' ' || maze[x + 1, y] == '.')
            {
                erasePlayerFromMaze();
                Console.SetCursorPosition(y, x);
                erasePlayer();
                x = x + 1;
                Console.SetCursorPosition(y, x);
                printPlayerInMaze(maze);
                printMaze(maze);
            }
        }
        public void printMaze(char[,] maze)
        {
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    Console.Write(maze[row, col]);
                }
                Console.WriteLine();
            }
        }
        public void erasePlayer()
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(x, y + 1);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(x, y + 2);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" ");
            }
        }
        public void printPlayerInMaze(char[,] maze)
        {
            int head = 254, head2 = 16, box = 219, foot = 124, armLeft = 47, armRight = 92;
            char[] line1 = new char[5] { ' ', Convert.ToChar(head2), Convert.ToChar(head), ' ', ' ' };
            char[] line2 = new char[5] { Convert.ToChar(armLeft), Convert.ToChar(box), Convert.ToChar(box), Convert.ToChar(box), Convert.ToChar(armRight) };
            char[] line3 = new char[5] { ' ', Convert.ToChar(foot), ' ', Convert.ToChar(foot), ' ' };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            for (int index = 0; index < 5; index++)
            {
                Console.Write(line1[index]);
            }
            Console.WriteLine();
            Console.SetCursorPosition(x, y + 1);
            for (int index = 0; index < 5; index++)
            {
                Console.Write(line2[index]);
            }
            Console.WriteLine();
            Console.SetCursorPosition(x, y + 2);
            for (int index = 0; index < 5; index++)
            {
                Console.Write(line3[index]);
            }

            for (int index = 0; index < 5; index++)
            {
                maze[x, y + index] = line1[index];
            }
            x += 1;
             Console.SetCursorPosition(x, y + 1);
            for (int index = 0; index < 5; index++)
            {
                maze[x, y + index] = line2[index];
            }
            x += 1;
            Console.SetCursorPosition(x, y + 2);
            for (int index = 0; index < 5; index++)
            {
                maze[x, y + index] = line3[index];
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
