﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanWithOOP.GL
{
    class GameGrid
    {
        GameCell[,] cells;
        int rows;
        int cols;
        public GameGrid(string fileName, int rows, int cols)
        {
            // Numbers of rows and columns should load from the file
            this.rows = rows;
            this.cols = cols;
            cells = new GameCell[rows, cols];
            this.loadGrid(fileName);
        }
        public GameCell getCell(int x, int y)
        {
            return cells[x, y];
        }
        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }

        void loadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record;
            for(int row = 0; row < this.rows; row++)
            {
                record = fp.ReadLine();
                for(int col = 0; col < this.cols; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    Char displayCharacter = record[col];
                    GameObjectType type = GameObject.GetGameObjectType(displayCharacter);
                    GameObject gameObject = new GameObject(type, displayCharacter);
                    cell.CurrentGameObject = gameObject;
                    cells[row, col] = cell;
                }
            }
            fp.Close();
        }
    }
}
