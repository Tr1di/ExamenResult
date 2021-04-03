using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public abstract class Potrebnost
    {
        public virtual int Id { get; }
        public virtual User Client { get; set; }
        public virtual User Rieltor { get; set; }
        public virtual string Adres { get; set; }
        public virtual Sdelka Sdelka { get; set; }
        public virtual int MinPrice { get; set; }
        public virtual int MaxPrice { get; set; }

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
            References(x => x.Client).Not.Nullable();
            References(x => x.Rieltor).Not.Nullable();
            References(x => x.Sdelka).Cascade.Lock();
        }
    }
}
