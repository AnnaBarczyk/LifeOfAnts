using System;

namespace LifeOfAnts.Ants
{
    public abstract class Ant
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Ant(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public abstract void Move();

        public virtual int GetDistanceToQueen(Queen queen)
        {
            int queenX = queen.PositionX;
            int queenY = queen.PositionX;
            int xDistance = Math.Abs(PositionX - queenX);
            int yDistance = Math.Abs(PositionY = queenY);
            int stepsToTheQueen = xDistance + yDistance;

            return stepsToTheQueen;
        }

        public virtual void CheckWhereToGo(Queen queen)
        {
        }

        public virtual void Update(Queen queen)
        {
        }
    }
}