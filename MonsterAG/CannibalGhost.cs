using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class CannibalGhost : Ghost
    {
        public CannibalGhost(string name) : base(name)
        {
            // Base constructor already sets Size to 1.
        }

        public void Eat(Ghost other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            // Absorb the other's size and set the eaten ghost's size to 0.
            this.Size += other.Size;
            other.Size = 0;
        }
    }
}
