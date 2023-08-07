using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanWithOOP.GL
{
    class GameObject
    {
        public char displayCharacter;
        public GameCell currentCell;
        public GameObjectType gameObjectType;
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.gameObjectType = type;
            this.displayCharacter = displayCharacter;
        }
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            if(displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return GameObjectType.WALL;
            }
            if(displayCharacter == '.')
            {
                return GameObjectType.REWARD;
            }
            return GameObjectType.NONE;
        }
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.CurrentGameObject = this;
            }
        }
    }
}
