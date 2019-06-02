using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    class HoleGenerator
    {
        static Random random { get; set; }
        List<Hole> holes;
        public HoleGenerator()
        {
            holes = new List<Hole>();
            random = new Random();
        }

        public List<Hole> getNewHoles(System.Windows.Forms.PictureBox mainScreen)
        {
            int numberOfHoles = 0;
            while (numberOfHoles != 5)
            {
                Point location = mainScreen.Location;
                int Width = mainScreen.Width;
                int Height = mainScreen.Height;

                int randXCoord = random.Next(30,Width-29);
                int randYCoord = random.Next(30,Height-29);
                Hole newHole = new Hole(randXCoord, randYCoord, 30, Color.Black);

                if (!checkCollision(newHole))
                {
                    holes.Add(newHole);
                    numberOfHoles++;
                }
            }

            return holes;
        }

        private bool checkCollision(Hole newHole)
        {
            foreach(Hole hole in holes)
            {
                if (hole.intersectWith(newHole))
                    return true;
            }
            return false;
        }

        public static int getRandomAngle(int Angle)
        {
            int[] angles = { 0, 90, 180, 270 };
            while (true)
            {
                int picker = random.Next(4);
                if (angles[picker] != Angle)
                    return angles[picker];
            }
        }
    }
}
