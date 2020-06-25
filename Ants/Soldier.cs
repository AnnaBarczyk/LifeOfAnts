namespace LifeOfAnts.Ants
{
    public class Soldier : Ant
    {
        private Compass _headTo = Compass.North;

        public Soldier(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override void Move()
        {
            switch (_headTo)
            {
                case Compass.North:
                    PositionY += 1;
                    _headTo = Compass.East;
                    break;
                case Compass.East:
                    PositionX += 1;
                    _headTo = Compass.South;
                    break;
                case Compass.South:
                    PositionY -= 1;
                    _headTo = Compass.West;
                    break;
                case Compass.West:
                    PositionX -= 1;
                    _headTo = Compass.North;
                    break;
            }
        }

        public override void Update(Queen queen)
        {
            Move();
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