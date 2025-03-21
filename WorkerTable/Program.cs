using System;
using Specter.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker("pt_PT");
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
            .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
            .RuleFor(faker => faker.FullName, (faker, f) => faker.FirstName + " " + faker.LastName);

            public string FirstName { get; set;}
            public string LastName { get; set;}
            public string FullName { get; set;}

            int n = 1;

            Faker faker = faker.Generate();

            //Create a table
            Table table = new Table();

            //add columns
            table.AddColum("ID");
            table.AddColum("Name");
            table.AddColum("Job");

            //Add Rows
            table.AddRow[args[0] -1];
            for (int args[0] >= 0, args[0]--)
                {
                    table.AddRow(n, name, job);
                    n++;
                }

            //Render the table
            AnsiConsole.Write(Table);
        }
    }
}
