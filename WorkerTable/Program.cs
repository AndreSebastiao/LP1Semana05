using System;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(((byte)int));
            Faker faker = new Faker("pt_PT");
        }
    }
}
