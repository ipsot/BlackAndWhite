using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackAndWhiote
{
    class WhiteFace:Face
    {
        private int countEaten;
        public WhiteFace(int x, int y, int hp) : base(x, y, Convert.ToChar(2), hp)
        {
            countEaten = 0;
        }

        public void Move(ConsoleKey key, PlayArea playArea)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    if (Y > playArea.MinY)
                    {
                        Y--;
                    }
                    break;
                case ConsoleKey.S:
                    if (Y < playArea.MaxY)
                    {
                        Y++;
                    }
                    break;
                case ConsoleKey.A:
                    if (X > playArea.MinX)
                    {
                        X--;
                    }
                    break;
                case ConsoleKey.D:
                    if (X < playArea.MaxX)
                    {
                        X++;
                    }
                    break;
            }
        }

        public void IncCountEaten()
        {
            countEaten++;
        }

        public int CountEaten
        {
            get { return countEaten; }
        }

        public new string GetInfo()
        {
            return base.GetInfo() + $" Count Eaten:{countEaten}";
        }
    }
}
