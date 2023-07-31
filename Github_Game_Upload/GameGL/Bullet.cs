using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGUI.GameGL
{
    class Bullet : GameObject
    {
        GameDirection direction;
        private bool hasHitEnemy = false;
        public bool HasHitEnemy { get => hasHitEnemy; }
        public Bullet(char DisplayCharacter, GameCell cell , GameObjectType type, GameDirection direction) : base(type, DisplayCharacter)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.CurrentCell = cell;
            this.direction = direction;
            this.GameObjectType = type;
        }
        public Bullet(Image img, GameCell cell) : base(GameObjectType.BULLET, img)
        {
            this.Image = img;
            this.CurrentCell = cell;
        }
        
        public void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }
        public GameCell nextCell()
        {
            return this.CurrentCell.nextCell(GameDirection.Right);
        }
        public void onEnemyCollision()
        {
            hasHitEnemy = true;
        }
    }
}
