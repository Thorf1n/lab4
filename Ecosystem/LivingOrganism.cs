

namespace Ecosystem
{
     abstract class LivingOrganism
    {
        public int Energy { get; set; }
        public int Age { get; set; }
        public string Size { get; set; }

        public abstract void Move();
    }
}
