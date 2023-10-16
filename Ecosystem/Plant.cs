

namespace Ecosystem
{
    internal class Plant : LivingOrganism, IReproducible
    {
        public string Flowering { get; set; }

        public void Reproduce()
        {
            Console.WriteLine("Plant reproduces");
        }

        public override void Move()
        {
            Console.WriteLine("Plant cannot move");
        }
    }
}
