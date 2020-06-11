using System;

namespace LifeOfAnts.Ants
{
    public class Worker: Ant
    {
        private Random _random = new Random();
        public override int positionX { get; set; }
        public override int positionY { get; set; }

        public Worker(int positionX, int positionY) : base(positionX, positionY)
        {
        }
        
        public override void Move()
        {
            int axisX = 0;
            
            if (_random.Next(2) == axisX)
            {
                int east = 1;
                int west = -1;

                if (_random.Next(2) == 0)
                {
                    positionX += east;
                }
                else
                {
                    positionX += west;
                }
            }
            else
            {
                int north = 1;
                int south = -1;

                if (_random.Next(2) == 0)
                {
                    positionX += north;
                }
                else
                {
                    positionX += south;
                }
            }
        }
    }
}