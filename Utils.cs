using System;

namespace LifeOfAnts
{
    public class Utils
    {
        public int GiveMeRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}