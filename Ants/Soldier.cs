namespace LifeOfAnts.Ants
{
    public class Soldier: Ant
    {
        public Soldier(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override int positionX { get; set; }
        public override int positionY { get; set; }
        private string _headTo = "north";
        public override void Move()
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