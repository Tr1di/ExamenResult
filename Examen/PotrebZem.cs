using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class PotrebZem : Potrebnost
    {
        public virtual float MinPloshad { get; set; }
        public virtual float MaxPloshad { get; set; }
    }

    internal class PotrebZemMap : SubclassMap<PotrebZem>
    {
        public PotrebZemMap()
        {
            DiscriminatorValue("PotrZem");

            Map(x => x.MinPloshad);
            Map(x => x.MaxPloshad);
        }
    }
}
