using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class SlimeGhost : Ghost
    {
        public SlimeGhost(string name) : base(name)
        {
            // Validierung für negativen Testfall: leerer oder nur Leerzeichen-Name ist nicht erlaubt.
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name darf nicht leer oder nur aus Leerzeichen bestehen.", nameof(name));
            }

            // Die Basis-Klasse setzt bereits die Anfangsgröße auf 1.
            this.Size = 1;
        }

        public string Slime()
        {
            return $"{Name} hinterlässt eine Schleimspur.";
        }

        // Versteckt die Basismethode, damit SlimeGhost.Haunt() die erwartete Ausgabe liefert.
        public new string Haunt()
        {
            return Slime() + Environment.NewLine + $"{Name} sagt: 'Buh'";
        }
    }
}
