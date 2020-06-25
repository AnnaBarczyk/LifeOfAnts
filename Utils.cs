using System;

namespace LifeOfAnts
{
    public static class Utils
    {
        public static int GiveMeRandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max + 1);
        }
    }
}