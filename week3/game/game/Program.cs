using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EZInput;
using System.Threading.Tasks;
using System.Threading;

namespace game
{
    class Program
    {
        private const char V = '#';

        static void Main(string[] args)
        {
            //Character player = new Character('@', 3, 3);
            //Character goal = new Character('!', 67, 46);

            char[,] maze = new char[,] {
            {V, '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
            {'#', '.', '#', '#', '#', '#', '#', '.', '.', '#'},
            {'#', '.', '#', '.', '.', '.', '#', '.', '.', '#'},
            {'#', '.', '#', '.', '#', '.', '#', '.', '.', '#'},
            {'#', '.', '#', '.', '.', '.', '#', '.', '.', '#'},
            {'#', '.', '#', '#', '#', '#', '#', '#', '.', '#'},
            {'#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
            {'#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
        };

            char[,] character = new char[,] {
            {'*', '*', '.', '.'},
            {'*', '*', '.', '.'},
            {'.', '.', '*', '*'},
            {'.', '.', '*', '*'}
        };

            Character myCharacter = new Character(character, 3, 3);

            myCharacter.DrawInMaze(maze);

            Console.Clear();
            myCharacter.printMaze(maze);
            myCharacter.printPlayerInMaze(maze);
            //printEnemy();
            while (true)
            {
                //printScore();
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    myCharacter.movePlayerLeft(maze);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    myCharacter.movePlayerRight(maze);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    myCharacter.movePlayerUp(maze);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    myCharacter.movePlayerDown(maze);
                }
                /*if (Keyboard.IsKeyPressed(Key.Space))
                {
                    generateBullet();
                }
                if (timer == 3)
                {
                    moveEnemy();
                    timer = 0;
                }
                moveBullet();
                bulletCollisionwithEnemy();
                timer++;*/
                Thread.Sleep(90);
                //printMaze(maze, player, goal);
            }
            /*static void erasePlayerFromMaze(Character character)
            {

                for (int row = 0; row < 5; row++)
                {
                    Console.SetCursorPosition(character + row, playerY);
                    for (int col = 0; col < 5; col++)
                    {
                        Console.Write(" ");
                    }
                }
            }*/
            /*static void printMaze(char[,] maze, Character player, Character goal)
            {
                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    for (int j = 0; j < maze.GetLength(1); j++)
                    {
                        if (player.X == j && player.Y == i)
                        {
                            Console.Write(player.Symbol);
                        }
                        else if (goal.X == j && goal.Y == i)
                        {
                            Console.Write(goal.Symbol);
                        }
                        else
                        {
                            Console.Write(maze[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }*/
        }
    }
}
