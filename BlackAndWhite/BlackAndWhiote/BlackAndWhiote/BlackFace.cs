using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackAndWhiote
{
    class BlackFace:Face
    {
        private static Random rnd = new Random();

        public BlackFace(int x, int y, int hp) : base(x, y, Convert.ToChar(1), hp)
        {

        }

        public void RandomPosition(PlayArea playArea)
        {
            X = rnd.Next(playArea.MinX, playArea.MaxX);
            Y = rnd.Next(playArea.MinY, playArea.MaxY);
        }
    }
}
