using System;
using System.Collections.Generic;
using LifeOfAnts.Ants;

namespace LifeOfAnts
{
    public class Hive
    {
        private static Random random = new Random();
        private static int HiveSize = random.Next(150,250);
        // TODO Size do konstruktora (Nie do konstruktora bo create ants korzysta  z nich?)
        private int maxHight = HiveSize;
        private int minHeight = HiveSize - (2 * HiveSize);
        private int maxLenght = HiveSize;
        private int minLenght = HiveSize - (2 * HiveSize);
        private int HowManyDrons;
        private int HowManyWorkers;
        private int HowManySoldiers;
        private Queen _antQueen;
        public List<Ant> listOfAnts;

        public Hive(int howManyDrons, int howManySoldiers, int howManyWorkers)
        {
            listOfAnts = new List<Ant> { };
            HowManyDrons = howManyDrons;
            HowManySoldiers = howManySoldiers;
            HowManyWorkers = howManyWorkers;
        }
        
        public void CreateAnts()
        {
            Console.WriteLine("Creating ants");
            _antQueen = new Queen(random.Next(minLenght, maxLenght), random.Next(minHeight, maxHight));
            listOfAnts.Add(_antQueen);

            for (int i = 0; i < HowManyDrons; i++)
            {
                listOfAnts.Add(new Drone(random.Next(minLenght,maxLenght), random.Next(minHeight, maxHight)));
            }
            for (int i = 0; i < HowManySoldiers; i++)
            {
                listOfAnts.Add(new Soldier(random.Next(minLenght,maxLenght), random.Next(minHeight, maxHight)));
            }
            for (int i = 0; i < HowManyWorkers; i++)
            {
                listOfAnts.Add(new Worker(random.Next(minLenght,maxLenght), random.Next(minHeight, maxHight)));
            }
        }

        public void LiveNewLife(int howManyTurns)
        {
            Console.WriteLine("Starting a new life in ants hive");
            for (int i = 0; i < howManyTurns; i++)
            {
                listOfAnts.ForEach(ant => ant.Update(_antQueen));
            }
        }
    }
}