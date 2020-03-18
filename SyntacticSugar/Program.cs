using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var hornedBeetlePredators = new List<string>()
            {
                "click beetles",
                "flat bark beetles",
                "clerid beetles",
                "ambush bugs",
                "thrips",
                "assassin bugs",
                "carpenter ants",
                "wasps"
            };

            var hornedBeetlePrey = new List<string>()
            {
                "birch",
                "chestnut",
                "green ash",
                "maple"
            };

            var mantisPredators = new List<string>()
            {
                "frogs",
                "bats",
                "monkeys",
                "larger birds",
                "spiders",
                "snakes"
            };

            var mantisPrey = new List<string>()
            {
                "lizards",
                "crickets",
                "moths",
                "flies",
                "flour worms",
                "other large insects they can catch"
            };

            var beetle = new Bug("Horned Beetle", "Anoplophora glabripennis", hornedBeetlePredators, hornedBeetlePrey);
            var mantis = new Bug("Dead Leaf Mantis", "Deroplatys desiccata", mantisPredators, mantisPrey);

            Console.WriteLine(beetle.Eat("maple"));
            Console.WriteLine(mantis.Eat("steak"));
            Console.WriteLine($"{mantis.FormalName} loves to eat {mantis.PreyList()}");
            Console.WriteLine($"Take cover {beetle.FormalName}! Here come the {beetle.PredatorList()}");
        }

    }
}
