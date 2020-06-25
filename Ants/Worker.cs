using System;

namespace LifeOfAnts.Ants
{
    public class Worker: Ant
    {
        public Worker(int positionX, int positionY) : base(positionX, positionY)
        {
        }
        
        public override void Move()
        {
            int axisX = 0;
            
            if (Utils.GiveMeRandomNumber(0,1) == axisX)
            {
                int east = 1;
                int west = -1;

                if (Utils.GiveMeRandomNumber(0,1) == 0)
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

                if (Utils.GiveMeRandomNumber(0,1) == 0)
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