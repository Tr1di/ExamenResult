using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Examen
{
    static class DataBase
    {
        private const string ConnectionString = @"Data Source = ERELID; Initial Catalog = TDExamen; Integrated Security = True";

        private static ISessionFactory SessionFactory { get; }

        private static ISession session;

        public static ISession Session
        {
            get
            {
                if (session == null || !session.IsOpen)
                    session = SessionFactory.OpenSession();

                return session;
            }
        }

        static DataBase()
        {
            SessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration
                    .MsSql2012.ConnectionString(ConnectionString))
                .Mappings(x => x.FluentMappings
                    .AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildConfiguration()
                .BuildSessionFactory();
        }
    }
}
