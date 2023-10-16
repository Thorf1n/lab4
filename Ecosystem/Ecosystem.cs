

namespace Ecosystem
{
    internal class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem(List<LivingOrganism> organisms)
        {
            this.organisms = organisms;
        }

        public void Interaction()
        {
            foreach (var organism in organisms)
            {
                if (organism is IPredator)
                {
                    var possiblePreys = organisms.FindAll(x => x is IReproducible && x != organism);
                    if (possiblePreys.Count > 0)
                    {
                        var prey = possiblePreys[0]; 
                        ((IPredator)organism).Hunt(prey);
                    }
                }
                else if (organism is IReproducible)
                {
                    ((IReproducible)organism).Reproduce();
                }
            }
        }
    }
}

