using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackAndWhiote
{
    class Program
    {
        static void Main(string[] args)
        {
            WhiteFace whiteFace = new WhiteFace(0,2,10);
            

            List<BlackFace> blackFaces = new List<BlackFace>()
            {
                new BlackFace(0, 0, -2),
                new BlackFace(0, 0, 1)
            };

            PlayArea playArea = new PlayArea()
            {
                MinX = 0,
                MaxX = Console.WindowWidth - 2,
                MinY = 2,
                MaxY = Console.WindowHeight - 3
            };

            foreach (BlackFace blackFace in blackFaces)
            {
                blackFace.RandomPosition(playArea);
            }

            while (whiteFace.IsAlive)
            {
                Console.Clear();
                Console.Write(whiteFace.GetInfo());

                foreach (BlackFace blackFace in blackFaces)
                {
                    blackFace.Print();
                }

                whiteFace.Print();

                whiteFace.Move(Console.ReadKey().Key, playArea);

                bool hasEaten = false;

                foreach (BlackFace blackFace in blackFaces)
                {
                    if (whiteFace.IsCollidingWithAnothreFace(blackFace))
                    {
                        whiteFace.EatAnotherFace(blackFace);
                        hasEaten = true;
                        break;
                    }
                }

                if (hasEaten)
                {
                    whiteFace.IncCountEaten();

                    foreach (BlackFace blackFace in blackFaces)
                    {
                        blackFace.RandomPosition(playArea);
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"Игра окончена. Вы съели {whiteFace.CountEaten} чёрных рож");
            Console.ReadKey();
        }
    }
}
