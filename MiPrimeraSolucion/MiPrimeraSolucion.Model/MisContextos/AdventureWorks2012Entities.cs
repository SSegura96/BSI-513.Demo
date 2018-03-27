namespace MiPrimeraSolucion.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class AdventureWorks2012Entities : DbContext
    {
        public AdventureWorks2012Entities(string connectionString)
        {
            this.Database.Connection.ConnectionString = connectionString;
        }

    }
}
