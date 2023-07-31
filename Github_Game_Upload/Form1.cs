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
    public partial class Form1 : Form
    {
        List<Ghost> ghost = new List<Ghost>();
        List<Ghost> ghost1 = new List<Ghost>();
        List<Ghost> ghost2 = new List<Ghost>();
        List<Bullet> bullets = new List<Bullet>();
        private bool hasFiredBullet = false;
        GamePlayer player;
        HorizontalGhost g;
        HorizontalGhost g1;
        HorizontalGhost g2;
        
        GameCell cell1;
        GameCell cell2;
        GameCell cell3;
        GameGrid grid;
        int score = 0;
        public Form1()
        {
            Game.score = 0;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 16, 47);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(13, 4);
            cell1 = grid.getCell(13, 44);
            cell2 = grid.getCell(8, 44);
            cell3 = grid.getCell(3, 44);
            player = new GamePlayer(pacManImage, startCell);
            g = new HorizontalGhost(Properties.Resources.enemy, cell1, GameObjectType.ENEMY, GameDirection.Left);
            g1 = new HorizontalGhost(Properties.Resources.ghost2, cell2, GameObjectType.ENEMY, GameDirection.Left);
            g2 = new HorizontalGhost(Properties.Resources.ghost, cell3, GameObjectType.ENEMY, GameDirection.Left);
            ghost.Add(g);
            ghost1.Add(g1);
            ghost2.Add(g2);
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

            if (score >= 8)
            {
                ghostTimer.Enabled = false;
                HorizontalGhost enemy = new HorizontalGhost(GameGUI.Properties.Resources.simplebox, g.CurrentCell);
                //Bullet ForEnemy = new Bullet(GameGUI.Properties.Resources.simplebox,b.CurrentCell = g.CurrentCell - 1);
                for (int i = 0; i < ghost.Count; i++)
                {
                    ghost.RemoveAt(i);
                }
                for(int i = 0; i < bullets.Count; i++)
                {
                    bullets.RemoveAt(i);
                }
                ghost1timer.Enabled = true;
            }
            if(score >= 18)
            {
                ghost1timer.Enabled = false;
                HorizontalGhost enemy = new HorizontalGhost(GameGUI.Properties.Resources.simplebox, g1.CurrentCell);
                //Bullet ForEnemy1 = new Bullet(GameGUI.Properties.Resources.simplebox, b1.CurrentCell);
                for (int i = 0; i < ghost1.Count; i++)
                {
                    ghost1.RemoveAt(i);
                }
                for (int i = 0; i < bullets.Count; i++)
                {
                    bullets.RemoveAt(i);
                }
                ghost2Timer.Enabled = true;
            }
            if(score >= 25)
            {
                ghost2Timer.Enabled = false;
                gameLoop.Enabled = false;
               
                HorizontalGhost enemy = new HorizontalGhost(GameGUI.Properties.Resources.simplebox, g2.CurrentCell);
                //Bullet ForEnemy2 = new Bullet(GameGUI.Properties.Resources.simplebox, b2.CurrentCell);
                for (int i = 0; i < ghost2.Count; i++)
                {
                    ghost2.RemoveAt(i);
                }
                for (int i = 0; i < bullets.Count; i++)
                {
                    bullets.RemoveAt(i);
                }
                MessageBox.Show("!!!!!!You Win!!!!!!");
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

        private void ghost1timer_Tick(object sender, EventArgs e)
        {
            foreach(Ghost i in ghost1)
            {
                i.MoveGhost(grid);
            }
        }

        private void ghost2Timer_Tick(object sender, EventArgs e)
        {
            foreach (Ghost i in ghost2)
            {
                i.MoveGhost(grid);
            }
        }
    }
}
