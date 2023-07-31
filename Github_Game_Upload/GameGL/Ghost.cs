using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGUI.GameGL
{
    abstract class Ghost : GameObject
    {
        public GameDirection direction;
        public Ghost(Image image, GameCell startCell) : base(GameObjectType.ENEMY, image)
        {
            this.CurrentCell = startCell;
        }
        public Ghost(char DisplayCharacter, GameObjectType type) : base(type, DisplayCharacter)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.GameObjectType = type;
        }

        public Ghost(Image img, GameObjectType type) : base(type, img)
        {
            this.GameObjectType = type;
            this.Image = img;
        }
        public abstract GameCell MoveGhost(GameGrid grid);
    }
}
