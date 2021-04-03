using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class Nedvijimost
    {
        public virtual int Id { get; }
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    internal class NedvijimostMap : ClassMap<Nedvijimost>
    {
        public NedvijimostMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
        }
    }
}
