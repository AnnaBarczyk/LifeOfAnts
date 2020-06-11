using System;

namespace LifeOfAnts.Ants
{
    public abstract class Ant
    {
        public abstract int positionX { get; set; }
        public abstract int positionY { get; set; }

        public Ant(int positionX, int positionY)
        {
            positionX = positionX;
            positionY = positionY;
        }

        public abstract void Move();

        public virtual int GetDistanceToQueen(Queen queen)
        {
            int queenX = queen.positionX;
            int queenY = queen.positionX;
            int xDistance = Math.Abs(positionX - queenX);
            int yDistance = Math.Abs(positionY = queenY);
            int stepsToTheQueen = xDistance + yDistance;

            return stepsToTheQueen;
        }
    }
}