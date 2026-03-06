using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class Ghost
    {
        private readonly string name;
        private int size;

        public Ghost(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.size = 1 ;
        }
        public string Name
        {
            get { return name; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Haunt()
        {
            return $"{Name} sagt: 'Buh'";
        }
    }
}
