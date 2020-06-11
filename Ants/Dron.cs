using System;
using System.Threading;

namespace LifeOfAnts.Ants
{
    public class Dron: Ant
    {
        public Dron(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override int positionX { get; set; }
        public override int positionY { get; set; }
        private string _headTo;
        private int _waitingTimer = 0;

        private void _checkWhereToGo(Queen queen)
        {
            int queenX = queen.positionX;
            int queenY = queen.positionY;
            
            

            if (Math.Abs(queenX - positionX) < Math.Abs(queenY - positionY))
            {
                if (queenX > 0)
                {
                    _headTo = "east";
                }
                else
                {
                    _headTo = "west";;
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
        }

        private void _kickoff()
        {
            Random random = new Random();

            int xKickoff = random.Next(positionX-100, positionX+101);
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

            positionX = xKickoff;
            positionY = yKickoff;
        }
        public override void Move()
        {
            if (_waitingTimer == 0)
            {
               if (_headTo == "north")
               {
                   positionY += 1;
                   _headTo = "east";
               }
               if (_headTo == "east")
               {
                   positionX += 1;
                   _headTo = "south";
               }
               if (_headTo == "south")
               {
                   positionY -= 1;
                   _headTo = "west";
               }
               if (_headTo == "west")
               {
                   positionX -= 1;
                   _headTo = "north";
               } 
            }

            if (_waitingTimer == 1)
            {
                _waitingTimer -= 1;
                _kickoff();
            }
            else
            {
                _waitingTimer -= 1;
            }
            
        }
        
        public override int GetDistanceToQueen(Queen queen)
        {
            int queenX = queen.positionX;
            int queenY = queen.positionX;
            int xDistance = Math.Abs(positionX - queenX);
            int yDistance = Math.Abs(positionY = queenY);
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
    }
}