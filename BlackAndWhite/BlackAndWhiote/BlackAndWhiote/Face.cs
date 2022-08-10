using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackAndWhiote
{
    abstract class Face
    {
        private int x, y;
        private char view;
        private int hp;

        protected Face(int x, int y, char view, int hp)
        {
            this.x = x;
            this.y = y;
            this.view = view;
            this.hp = hp;
        }

        protected int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool IsAlive
        {
            get { return hp > 0; }
        }

        public bool IsCollidingWithAnothreFace(Face anotherFace)
        {
            return x == anotherFace.x && y == anotherFace.y;
        }

        public void EatAnotherFace(Face anotherFace)
        {
            hp += anotherFace.hp;
        }

        public void Print()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(view);
        }

        protected string GetInfo()
        {
            return $"X:{x} Y:{y} Hp:{hp}";
        }
    }
}
