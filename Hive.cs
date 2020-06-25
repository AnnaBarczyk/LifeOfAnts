using System;
using System.Collections.Generic;
using LifeOfAnts.Ants;

namespace LifeOfAnts
{
    public class Hive
    {
        private readonly int _howManyDrones;
        private readonly int _howManySoldiers;
        private readonly int _howManyWorkers;
        private readonly int _maxHeight;
        private readonly int _maxLength;
        private readonly int _minHeight;
        private readonly int _minLength;
        private readonly List<Ant> _listOfAnts;
        private Queen _antQueen;

        public Hive(int howManyDrones, int howManySoldiers, int howManyWorkers)
        {
            var hiveSize = Utils.GiveMeRandomNumber(150, 250);
            _maxHeight = hiveSize;
            _minHeight = hiveSize - 2 * hiveSize;
            _maxLength = hiveSize;
            _minLength = hiveSize - 2 * hiveSize;
            _listOfAnts = new List<Ant>();
            _howManyDrones = howManyDrones;
            _howManySoldiers = howManySoldiers;
            _howManyWorkers = howManyWorkers;
        }

        public void CreateAnts()
        {
            Console.WriteLine("Creating ants");
            _antQueen = new Queen(Utils.GiveMeRandomNumber(_minLength, _maxLength),
                Utils.GiveMeRandomNumber(_minHeight, _maxHeight));
            _listOfAnts.Add(_antQueen);

            for (var i = 0; i < _howManyDrones; i++)
                _listOfAnts.Add(new Drone(Utils.GiveMeRandomNumber(_minLength, _maxLength),
                    Utils.GiveMeRandomNumber(_minHeight, _maxHeight)));
            for (var i = 0; i < _howManySoldiers; i++)
                _listOfAnts.Add(new Soldier(Utils.GiveMeRandomNumber(_minLength, _maxLength),
                    Utils.GiveMeRandomNumber(_minHeight, _maxHeight)));
            for (var i = 0; i < _howManyWorkers; i++)
                _listOfAnts.Add(new Worker(Utils.GiveMeRandomNumber(_minLength, _maxLength),
                    Utils.GiveMeRandomNumber(_minHeight, _maxHeight)));
        }

        public void LiveNewLife(int howManyTurns)
        {
            Console.WriteLine("Starting a new life in ants hive");
            for (var i = 0; i < howManyTurns; i++) _listOfAnts.ForEach(ant => ant.Update(_antQueen));
        }
    }
}