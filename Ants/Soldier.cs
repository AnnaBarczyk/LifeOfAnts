using System;

namespace LifeOfAnts.Ants
{
    public class Soldier: Ant
    {
        public Soldier(int positionX, int positionY) : base(positionX, positionY)
        {
        }
        private string _headTo = "north";
        public override void Move()
        {
            // TODO: Rozwiązać na enumach
            if (_headTo == "north")
            {
                PositionY += 1;
                _headTo = "east";
            }
            else if (_headTo == "east")
            {
                PositionX += 1;
                _headTo = "south";
            }
            else if (_headTo == "south")
            {
                PositionY -= 1;
                _headTo = "west";
            }
            else if (_headTo == "west")
            {
                PositionX -= 1;
                _headTo = "north";
            }
            // Console.WriteLine("Soldier" + PositionX + " " + PositionY);
        }
        public override void Update(Queen queen)
        {
            Move();
        }
    }
}