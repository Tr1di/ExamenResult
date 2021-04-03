using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class User
    {
        public virtual int Id { get; }
        public virtual string Name { get; set; }
        public virtual IList<Potrebnost> Potrebnosti { get; set; }
        public virtual IList<Predlojenie> Predlojeniya { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    internal class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.Potrebnosti);
            HasMany(x => x.Predlojeniya);
        }
    }
}
