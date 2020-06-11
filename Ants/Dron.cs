using System;

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

        private void _checkWhereToGo(Queen queen)
        {
            int queenX = queen.positionX;
            int queenY = queen.positionY;

            if (Math.Abs(queenX - positionX) < Math.Abs(queenY - positionY))
            {
                if (queenX > 0)
                {
                    positionX += 1;
                }
                else
                {
                    positionX -= 1;
                }
            }
            else
            {
                if (queenY > 0)
                {
                    positionX += 1;
                }
                else
                {
                    positionY -= 1;
                } 
            }
        }
        public override void Move()
        {
            if (this.GetDistanceToQueen() > 3)
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
        }
    }
}