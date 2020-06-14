using System;
using System.Collections.Generic;
using LifeOfAnts.Ants;

namespace LifeOfAnts
{
    public class Hive
    {
        static Random random = new Random();
        static int HiveSize = random.Next(150,250);
        private int maxHight = HiveSize;
        private int minHeight = HiveSize - (2 * HiveSize);
        private int maxLenght = HiveSize;
        private int minLenght = HiveSize - (2 * HiveSize);
        private int HowManyDrons;
        private int HowManyWorkers;
        private int HowManySoldiers;
        public Queen AntQueen;
        
        public List<Ant> listOfAnts = new List<Ant> { };

        public Hive(int howManyDrons, int howManySoldiers, int howManyWorkers)
        {
            HowManyDrons = howManyDrons;
            HowManySoldiers = howManySoldiers;
            HowManyWorkers = howManyWorkers;
        }
        
        public void CreateAnts()
        {
            AntQueen = new Queen(random.Next(minLenght, maxLenght), random.Next(minHeight, maxHight));
            listOfAnts.Add(AntQueen);
            
            for (int i = 0; i > HowManyDrons; i++)
            {
                listOfAnts.Add(new Dron(random.Next(minLenght,maxLenght), random.Next(minHeight, maxHight)));
            }
            for (int i = 0; i > HowManySoldiers; i++)
            {
                listOfAnts.Add(new Soldier(random.Next(minLenght,maxLenght), random.Next(minHeight, maxHight)));
            }
            for (int i = 0; i > HowManyWorkers; i++)
            {
                listOfAnts.Add(new Worker(random.Next(minLenght,maxLenght), random.Next(minHeight, maxHight)));
            }
        }

        public void LiveNewLife(int howManyTurns)
        {
            for (int i = 0; i < howManyTurns; i++)
            {
               foreach (Ant ant in listOfAnts)
               {
                   if (ant.GetType().Name != "Dron")
                   {
                       ant.Move();
                   }
                   else
                   {
                       ant.GetDistanceToQueen(AntQueen);
                       ant.Move();
                       ant.GetDistanceToQueen(AntQueen);
                   }
               } 
            }
        }
    }
}