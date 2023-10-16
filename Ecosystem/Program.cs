namespace Ecosystem
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            var organism1 = new Animal { Energy = 100, Age = 5, Size = "large", Speed = 10 };
            var organism2 = new Plant { Energy = 50, Age = 2, Size = "medium", Flowering = "summer" };
            var organism3 = new Microorganism { Energy = 20, Age = 1, Size = "small", Type = "bacteria" };

            var organisms = new List<LivingOrganism> { organism1, organism2, organism3 };

            var ecosystem = new Ecosystem(organisms);

            
            ecosystem.Interaction();

            
            foreach (var organism in organisms)
            {
                organism.Move();
            }
        }
    }
}