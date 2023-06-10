using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class GameObject
    {
        public char[,] shape;
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public string d;
        public int d2 = 0;

        public GameObject()
        {
            shape = new char[1, 3] { { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }

        public GameObject(char[,] shape, Point StartingPoint)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            Premises = new Boundary();
            Direction = "LeftToRight";

        }

        public GameObject(char[,] shape, Point StartingPoint, Boundary Premises, string Direction)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
        }

        public void Move()
        {
            if (Direction == "LeftToRight")
            {
                movelefttoright();
            }
            else if (Direction == "RightToLeft")
            {
                moverighttoleft();
            }
            else if (Direction == "Patrol")
            {
                movepatrol();
            }
            else if (Direction == "Diagonal")
            {
                moveDiagonal();
            }
            else if (Direction == "Projectile")
            {
                moveProjectile();
            }
        }

        public void draw()
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(StartingPoint.y + j, StartingPoint.x + i);
                    Console.Write(shape[j, i]);
                }
            }
        }

        public void Erase()
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(StartingPoint.y + j, StartingPoint.x + i);
                    Console.Write(" ");
                }
            }
        }

        public void movepatrol()
        {
            if (d == "left")
            {
                if (StartingPoint.y > Premises.TopLeft.x)
                {
                    StartingPoint.y--;
                }
                else
                {
                    d = "right";
                }
            }
            else if (d == "right")
            {
                if (StartingPoint.y < Premises.TopRight.x)
                {
                    StartingPoint.y++;
                }
                else
                {
                    d = "left";
                }
            }

        }

        public void moveProjectile()
        {
            if (d2 < 6)
            {
                if (StartingPoint.x < Premises.TopRight.x)
                {
                    StartingPoint.y++;
                    StartingPoint.x--;
                    d2++;
                }
            }
            else if (d2 >= 6 && d2 < 8)
            {
                if (StartingPoint.y < Premises.TopRight.x)
                {
                    StartingPoint.y++;
                }
            }
            else if (d2 >= 8 && d2 < 12)
            {
                if (StartingPoint.x < Premises.BottomRight.y)
                {
                    StartingPoint.x++;
                    StartingPoint.y++;
                    d2++;
                }
            }
        }
        public void moveDiagonal()
        {
            if (StartingPoint.x < Premises.BottomRight.y)
            {
                StartingPoint.y++;
                StartingPoint.x++;
            }

        }
        public void movelefttoright()
        {
            if (StartingPoint.y <= Premises.TopRight.x)
            {
                StartingPoint.y++;
            }
        }
        public void moverighttoleft()
        {
            if (StartingPoint.y > Premises.TopLeft.x)
            {
                StartingPoint.y--;
            }
        }

    }
}
