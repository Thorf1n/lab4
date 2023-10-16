
namespace Ecosystem
{
    internal class Animal : LivingOrganism, IPredator
    {
        public int Speed { get; set; }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine("Predator attacks organism with energy " + prey.Energy);
        }

        public override void Move()
        {
            Console.WriteLine("Animal moves with a speed of " + Speed);
        }

    }
}
