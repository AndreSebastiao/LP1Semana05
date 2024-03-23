using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVillains = int.Parse(args[0]);

            Enemy[] villains = new Enemy[numberOfVillains];

            for (int i = 0; i < villains.Length; i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");

                string name = Console.ReadLine();

                villains[i] = new Enemy(name);
            }

            foreach(Enemy enemy in villains)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
        }
    }
}
