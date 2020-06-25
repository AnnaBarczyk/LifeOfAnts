using System;

namespace LifeOfAnts.Ants
{
    public abstract class Ant
    {
        protected Ant(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }

        public abstract void Move();

        public virtual int GetDistanceToQueen(Queen queen)
        {
            var queenX = queen.PositionX;
            var queenY = queen.PositionX;
            var xDistance = Math.Abs(PositionX - queenX);
            var yDistance = Math.Abs(PositionY = queenY);
            var stepsToTheQueen = xDistance + yDistance;

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