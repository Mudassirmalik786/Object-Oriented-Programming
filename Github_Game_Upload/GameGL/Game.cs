using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGUI.GameGL
{
    public class Game
    {
        public static int score = 0;
        static bool flag = true;
        static int Health = 5;
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, GameGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static GameObject getCurrentObject(GameCell c)
        {
            GameObject Object = new GameObject(c.CurrentGameObject.GameObjectType, c.CurrentGameObject.Image);
            return Object;
        }
        public static void AddScore()
        {
            score++;
        }
        public static void SetFlag()
        {
            flag = false;
        }
        public static bool GetFlag()
        {
            return flag;
        }
        public static int ReturnScore()
        {
            return score;
        }
        public static void decreaseHealth()
        {
            Health--;
        }

        public static int getHealth()
        {
            return Health;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = GameGUI.Properties.Resources.simplebox;

            if (displayCharacter == '#')
            {
                img = GameGUI.Properties.Resources.horizontal;
            }
            if(displayCharacter == '|')
            {
                img = GameGUI.Properties.Resources.vertical;
            }

            if (displayCharacter == '$')
            {
                img = GameGUI.Properties.Resources.obstacle;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = GameGUI.Properties.Resources.GamePlayer;
            }
            return img;
        }
    }
}
