using System;
using static LifeOfAnts.Utils;

namespace LifeOfAnts.Ants
{
    public class Worker: Ant
    {
        public Worker(int positionX, int positionY) : base(positionX, positionY)
        {
        }
        
        public override void Move()
        {
            const int axisX = 0;
            const int north = 1;
            const int south = -1;

            const int east = 1;
            const int west = -1;
            if (GiveMeRandomNumber(0,1) == axisX)
            {
                if (GiveMeRandomNumber(0,1) == 0)
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
                if (GiveMeRandomNumber(0,1) == 0)
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