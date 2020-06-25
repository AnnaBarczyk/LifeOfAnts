using System;

namespace LifeOfAnts.Ants
{
    public class Worker: Ant
    {
        // TODO: jeden statyczny random w utilsach
        private Random _random = new Random();
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
                    PositionX += east;
                }
                else
                {
                    PositionX += west;
                }
            }
            else
            {
                int north = 1;
                int south = -1;

                if (_random.Next(2) == 0)
                {
                    PositionX += north;
                }
                else
                {
                    PositionX += south;
                }
            }
            // Console.WriteLine("Worker" + PositionX + " " + PositionY);
        }
        public override void Update(Queen queen)
        {
            Move();
        }
    }
}