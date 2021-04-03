using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class PotrebDom : Potrebnost
    {
        public virtual float MinPloshad { get; set; }
        public virtual float MaxPloshad { get; set; }

        public virtual float MinKomnat { get; set; }
        public virtual float MaxKomnat { get; set; }

        public virtual float MinEtajnost { get; set; }
        public virtual float MaxEtajnost { get; set; }
    }

    internal class PotrebDomMap : SubclassMap<PotrebDom>
    {
        public PotrebDomMap()
        {
            DiscriminatorValue("PotrDom");

            Map(x => x.MinPloshad);
            Map(x => x.MaxPloshad);

            Map(x => x.MinKomnat);
            Map(x => x.MaxKomnat);

            Map(x => x.MinEtajnost);
            Map(x => x.MaxEtajnost);
        }
    }
}
