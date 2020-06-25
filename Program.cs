using System;
using System.Collections.Generic;
using LifeOfAnts.Ants;


namespace LifeOfAnts
{
    class Program
    {
        static void Main(string[] args)
        {
            var hive = new Hive(2,5,10);
            hive.CreateAnts();
            hive.LiveNewLife(100);
        }
    }
}