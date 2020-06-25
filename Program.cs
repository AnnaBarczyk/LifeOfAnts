using System;
using System.Collections.Generic;
using LifeOfAnts.Ants;


namespace LifeOfAnts
{
    class Program
    {
        static void Main(string[] args)
        {
            Hive hive = new Hive(1,1,1);
            hive.CreateAnts();
            hive.LiveNewLife(100);
            List<Ant> lista = hive.listOfAnts;
            foreach (var ant in lista)
            {
                Console.WriteLine(ant.GetType());
            }
        }
    }
}