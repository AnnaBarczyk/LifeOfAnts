using System;

namespace LifeOfAnts.Ants
{
    public class Queen: Ant
    {
        private int _countdownTimer;
        private bool _firtsMatingMood = true;
        private Random _random = new Random();

        public Queen(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override void Move()
        {
            // Console.WriteLine("Queen" + PositionX + " " + PositionY);
            PositionX += 0;
            PositionY += 0;
            if (_countdownTimer > 0)
            {
                _countdownTimer -= 1;
            }
        }

        public bool IsInMatingMood()
        {
            bool matingMood;

            if (_firtsMatingMood == true)
            {
                _firtsMatingMood = false;

                if (_random.Next(2) == 0)
                {
                    matingMood = false;
                }
                else
                {
                    matingMood = true;
                }
            }
            else
            {
                if (_countdownTimer == 0)
                {
                    matingMood = true;
                }
                else
                {
                    matingMood = false;
                }
            }

            return matingMood;
        }
        public override void Update(Queen queen)
        {
            Move();
        }
    }
} 