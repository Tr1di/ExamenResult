using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class PotrebKvartira : Potrebnost
    {
        public virtual float MinPloshad { get; set; }
        public virtual float MaxPloshad { get; set; }

        public virtual float MinKomnat { get; set; }
        public virtual float MaxKomnat { get; set; }

        public virtual float MinEtaj { get; set; }
        public virtual float MaxEtaj { get; set; }
    }

    internal class PotrebKvartiraMap : SubclassMap<PotrebKvartira>
    {
        public PotrebKvartiraMap()
        {
            DiscriminatorValue("PotrKvar");

            Map(x => x.MinPloshad);
            Map(x => x.MaxPloshad);

            Map(x => x.MinKomnat);
            Map(x => x.MaxKomnat);

            Map(x => x.MinEtaj);
            Map(x => x.MaxEtaj);
        }
    }
}
