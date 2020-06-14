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
            if (_headTo == "north")
            {
                PositionY += 1;
                _headTo = "east";
            }
            if (_headTo == "east")
            {
                PositionX += 1;
                _headTo = "south";
            }
            if (_headTo == "south")
            {
                PositionY -= 1;
                _headTo = "west";
            }
            if (_headTo == "west")
            {
                PositionX -= 1;
                _headTo = "north";
            }
        }
    }
}