
namespace Ecosystem
{
    internal class Microorganism : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public void Reproduce()
        {
            Console.WriteLine("Microorganism multiplies");
        }

        public override void Move()
        {
            Console.WriteLine("Microorganism moves microscopically");
        } 
    }
}
