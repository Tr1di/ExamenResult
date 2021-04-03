using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class Predlojenie
    {
        public virtual int Id { get; }
        public virtual User Client { get; set; }
        public virtual User Rieltor { get; set; }
        public virtual Nedvijimost Nedvijimost { get; set; }
        public virtual Sdelka Sdelka { get; set; }
        public virtual int Price { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

        internal class PredlojenieMap : ClassMap<Predlojenie>
        {
            public PredlojenieMap()
            {
                Id(x => x.Id).GeneratedBy.Identity();
                Map(x => x.Price).Not.Nullable();
                References(x => x.Client).Not.Nullable();
                References(x => x.Rieltor).Not.Nullable();
                References(x => x.Nedvijimost).Not.Nullable();
                References(x => x.Sdelka);
            }
        }
    }
}
