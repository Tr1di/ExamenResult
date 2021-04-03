using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class Potrebnost
    {
        public virtual int Id { get; }

        public virtual User Client { get; set; }
        public virtual User Rieltor { get; set; }

        public virtual string NedvijType { get; set; }

        public virtual string Adres { get; set; }

        public virtual Sdelka Sdelka { get; set; }

        public virtual int MinPrice { get; set; }
        public virtual int MaxPrice { get; set; }

        public virtual float MinPloshad { get; set; }
        public virtual float MaxPloshad { get; set; }

        public virtual float MinKomnat { get; set; }
        public virtual float MaxKomnat { get; set; }

        public virtual float MinEtaj { get; set; }
        public virtual float MaxEtaj { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    internal class PotrebnostMap : ClassMap<Potrebnost>
    {
        public PotrebnostMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.MinPrice);
            Map(x => x.MaxPrice);

            Map(x => x.NedvijType).Not.Nullable();

            References(x => x.Client).Not.Nullable();
            References(x => x.Rieltor).Not.Nullable();

            References(x => x.Sdelka);

            Map(x => x.MinPloshad);
            Map(x => x.MaxPloshad);

            Map(x => x.MinKomnat);
            Map(x => x.MaxKomnat);

            Map(x => x.MinEtaj);
            Map(x => x.MaxEtaj);
        }
    }
}
