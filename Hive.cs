using System;
using System.Collections.Generic;
using LifeOfAnts.Ants;

namespace LifeOfAnts
{
    public class Hive
    {
        private static int HiveSize;
        private int maxHight;
        private int minHeight;
        private int maxLenght;
        private int minLenght;
        private int _howManyDrones;
        private int HowManyWorkers;
        private int HowManySoldiers;
        private Queen _antQueen;
        public List<Ant> listOfAnts;

        public Hive(int howManyDrones, int howManySoldiers, int howManyWorkers)
        {
            HiveSize = Utils.GiveMeRandomNumber(150,250);
            maxHight = HiveSize;
            minHeight = HiveSize - (2 * HiveSize);
            maxLenght = HiveSize;
            minLenght = HiveSize - (2 * HiveSize);
            listOfAnts = new List<Ant> { };
            _howManyDrones = howManyDrones;
            HowManySoldiers = howManySoldiers;
            HowManyWorkers = howManyWorkers;
        }
        
        public void CreateAnts()
        {
            Console.WriteLine("Creating ants");
            _antQueen = new Queen(Utils.GiveMeRandomNumber(minLenght, maxLenght), Utils.GiveMeRandomNumber(minHeight, maxHight));
            listOfAnts.Add(_antQueen);

            for (int i = 0; i < _howManyDrones; i++)
            {
                listOfAnts.Add(new Drone(Utils.GiveMeRandomNumber(minLenght,maxLenght), Utils.GiveMeRandomNumber(minHeight, maxHight)));
            }
            for (int i = 0; i < HowManySoldiers; i++)
            {
                listOfAnts.Add(new Soldier(Utils.GiveMeRandomNumber(minLenght,maxLenght), Utils.GiveMeRandomNumber(minHeight, maxHight)));
            }
            for (int i = 0; i < HowManyWorkers; i++)
            {
                listOfAnts.Add(new Worker(Utils.GiveMeRandomNumber(minLenght,maxLenght), Utils.GiveMeRandomNumber(minHeight, maxHight)));
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