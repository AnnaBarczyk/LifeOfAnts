using System;
using System.Threading;

namespace LifeOfAnts.Ants
{
    public class Drone : Ant
    {
        public Drone(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        private string _headTo;
        private int _waitingTimer = 0;

        public override void CheckWhereToGo(Queen queen)
        {
            int queenX = queen.PositionX;
            int queenY = queen.PositionY;

            Console.WriteLine("queen " + queenX + " " + queenY);

            if (Math.Abs(queenX - PositionX) < Math.Abs(queenY - PositionY))
            {
                if (queenX > 0)
                {
                    _headTo = "east";
                }
                else
                {
                    _headTo = "west";
                    ;
                }
            }
            else
            {
                if (queenY > 0)
                {
                    _headTo = "north";
                }
                else
                {
                    _headTo = "south";
                }
            }

            Console.WriteLine("head to " + _headTo);
            // Console.WriteLine("timer " + _waitingTimer);
        }

        private void _kickoff()
        {
            Console.WriteLine("Drone kicked off");
            Random random = new Random();

            int xKickoff = random.Next(PositionX - 100, PositionX + 101);
            int yKickoff;
            int stepsLeft = Math.Abs(100 - xKickoff);
            if (random.Next(2) == 0)
            {
                yKickoff = stepsLeft;
            }
            else
            {
                yKickoff = stepsLeft - (2 * stepsLeft);
            }

            PositionX = xKickoff;
            PositionY = yKickoff;
        }

        public override void Move()
        {
            if (_waitingTimer == 0)
            {
                Console.WriteLine("Drone before" + PositionX + " " + PositionY);
                Console.WriteLine("Starting to move " + _headTo);
                if (_headTo == "north")
                {
                    PositionY += 1;
                    Console.WriteLine(PositionY + " north movement");
                }
                else if (_headTo == "east")
                {
                    PositionX += 1;
                    Console.WriteLine(PositionX + " east movement");
                }
                else if (_headTo == "south")
                {
                    PositionY -= 1;
                    Console.WriteLine(PositionY + "south movement");
                }
                else if (_headTo == "west")
                {
                    PositionX -= 1;
                    Console.WriteLine(PositionX + "west movement");
                }
            }
            else if (_waitingTimer == 1)
            {
                _waitingTimer -= 1;
                _kickoff();
            }
            else
            {
                _waitingTimer -= 1;
            }

            Console.WriteLine("Drone after" + PositionX + " " + PositionY);
        }

        public override int GetDistanceToQueen(Queen queen)
        {
            // TODO: Single resposibility
            int queenX = queen.PositionX;
            int queenY = queen.PositionX;
            int xDistance = Math.Abs(PositionX - queenX);
            int yDistance = Math.Abs(PositionY = queenY);
            int stepsToTheQueen = xDistance + yDistance;

            if (stepsToTheQueen <= 3)
            {
                if (queen.IsInMatingMood())
                {
                    Console.WriteLine("Hallelujah!");
                    _waitingTimer = 10;
                }
                else
                {
                    Console.WriteLine("D'oh!");
                    _kickoff();
                }
            }

            return stepsToTheQueen;
        }

        public override void Update(Queen queen)
        {
            GetDistanceToQueen(queen);
            CheckWhereToGo(queen);
            Move();
            GetDistanceToQueen(queen);
        }
    }
}