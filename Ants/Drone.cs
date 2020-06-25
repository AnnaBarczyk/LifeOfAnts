using System;

namespace LifeOfAnts.Ants
{
    public class Drone : Ant
    {
        private Compass _headTo;
        private int _waitingTimer;

        public Drone(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override void CheckWhereToGo(Queen queen)
        {
            var queenX = queen.PositionX;
            var queenY = queen.PositionY;

            Console.WriteLine("queen " + queenX + " " + queenY);

            if (Math.Abs(queenX - PositionX) < Math.Abs(queenY - PositionY))
            {
                if (queenX > 0)
                {
                    _headTo = Compass.East;
                }
                else
                {
                    _headTo = Compass.West;
                    ;
                }
            }
            else
            {
                _headTo = queenY > 0 ? Compass.North : Compass.South;
            }

            Console.WriteLine("head to " + _headTo);
        }

        private void _kickoff()
        {
            Console.WriteLine("Drone kicked off");
            var xKickoff = Utils.GiveMeRandomNumber(PositionX - 100, PositionX + 100);
            int yKickoff;
            var stepsLeft = Math.Abs(100 - xKickoff);
            if (Utils.GiveMeRandomNumber(0, 1) == 0)
                yKickoff = stepsLeft;
            else
                yKickoff = stepsLeft - 2 * stepsLeft;

            PositionX = xKickoff;
            PositionY = yKickoff;
        }

        public override void Move()
        {
            if (_waitingTimer == 0)
            {
                Console.WriteLine("Drone before" + PositionX + " " + PositionY);
                Console.WriteLine("Starting to move " + _headTo);
                if (_headTo == Compass.North)
                {
                    PositionY += 1;
                    Console.WriteLine(PositionY + " north movement");
                }
                else if (_headTo == Compass.East)
                {
                    PositionX += 1;
                    Console.WriteLine(PositionX + " east movement");
                }
                else if (_headTo == Compass.South)
                {
                    PositionY -= 1;
                    Console.WriteLine(PositionY + "south movement");
                }
                else if (_headTo == Compass.West)
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
            var queenX = queen.PositionX;
            var queenY = queen.PositionX;
            var xDistance = Math.Abs(PositionX - queenX);
            var yDistance = Math.Abs(PositionY = queenY);
            var stepsToTheQueen = xDistance + yDistance;

            if (stepsToTheQueen > 3) return stepsToTheQueen;
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

            return stepsToTheQueen;
        }

        public override void Update(Queen queen)
        {
            GetDistanceToQueen(queen);
            CheckWhereToGo(queen);
            Move();
            GetDistanceToQueen(queen);
        }

        private enum Compass
        {
            North,
            East,
            South,
            West
        }
    }
}