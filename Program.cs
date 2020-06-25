namespace LifeOfAnts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hive = new Hive(2, 5, 10);
            hive.CreateAnts();
            hive.LiveNewLife(100);
        }
    }
}