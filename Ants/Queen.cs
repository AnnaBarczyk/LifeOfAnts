using System;

namespace LifeOfAnts.Ants
{
    public class Queen: Ant
    {
        private int _countdownTimer { get; set; }
        private bool _firtsMatingMood = true;
        private Random _random = new Random();
        public override int positionX { get; set; }
        public override int positionY { get; set; }
        
        public Queen(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override void Move()
        {
            positionX += 0;
            positionY += 0;
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
    }
} 