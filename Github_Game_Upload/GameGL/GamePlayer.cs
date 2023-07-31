using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGUI.GameGL
{
    class GamePlayer : GameObject
    {
        public static List<Bullet> bullets;
        public GamePlayer(Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }
        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (currentCell != nextCell)
            {
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
                {
                    Game.decreaseHealth();
                }
                this.CurrentCell = nextCell;
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }
        public void moveBullets()
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell())
                {
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(Game.getBlankGameObject());
                    bullets.RemoveAt(i);
                    i--;
                }
                else if (bullets[i].nextCell().CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
                {
                    if (!bullets[i].HasHitEnemy)
                    {
                        Game.AddScore();
                        bullets[i].onEnemyCollision();
                    }
                }
                else
                {
                    bullets[i].move(bullets[i].nextCell());
                }
            }
           
        }
        
        public void generateBullet()
        {
            Bullet bullet = new Bullet(GameGUI.Properties.Resources.bullet, this.CurrentCell.nextCell(GameDirection.Right));
            bullets.Add(bullet);
        }
    }
}
