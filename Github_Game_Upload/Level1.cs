using EZInput;
using GameGUI.GameGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGUI
{
    public partial class Level1 : Form
    {
        List<Ghost> ghost = new List<Ghost>();
        List<Bullet> bullets = new List<Bullet>();
        private bool hasFiredBullet = false;
        GamePlayer player;
        HorizontalGhost g;
        GameCell cell1;
        GameGrid grid;
        int score = 0;
        public Level1()
        {
            Game.score = 0;
            InitializeComponent();
        }
        private void Level1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze2.txt", 6, 47);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(3, 4);
            cell1 = grid.getCell(3, 44);
            player = new GamePlayer(pacManImage, startCell);
            g = new HorizontalGhost(Properties.Resources.ghost, cell1, GameObjectType.ENEMY, GameDirection.Left);
            ghost.Add(g);
            printMaze(grid);
        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);

            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);

            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);

            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);

            }
            if (Keyboard.IsKeyPressed(Key.Space) && !hasFiredBullet)
            {
                player.generateBullet();
            }

            

            progressBar1.Value = Game.getHealth() * 20;

            if (score >= 10)
            {
                ghostTimer.Enabled = false;
                gameLoop.Enabled = false;
                HorizontalGhost enemy = new HorizontalGhost(GameGUI.Properties.Resources.simplebox, g.CurrentCell);
                //Bullet ForEnemy = new Bullet(GameGUI.Properties.Resources.simplebox,b.CurrentCell = g.CurrentCell - 1);
                for (int i = 0; i < ghost.Count; i++)
                {
                    ghost.RemoveAt(i);
                }
                for (int i = 0; i < bullets.Count; i++)
                {
                    bullets.RemoveAt(i);
                }
                MessageBox.Show("!!!You won!!!");
                this.Close();
            }
            if (Game.getHealth() <= 0)
            {
                gameLoop.Enabled = false;
                MessageBox.Show("You Loose");
                this.Close();
            }
        }

        private void ghostTimer_Tick(object sender, EventArgs e)
        {
            foreach (Ghost i in ghost)
            {
                i.MoveGhost(grid);
            }
        }

        private void bulletLoop_Tick(object sender, EventArgs e)
        {
            player.moveBullets();
            score = Game.ReturnScore();
            lblScore.Text = "Score: " + score.ToString();
        }

        
    }
}
