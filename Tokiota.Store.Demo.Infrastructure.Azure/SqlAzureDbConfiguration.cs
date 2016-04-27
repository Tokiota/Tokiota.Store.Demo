namespace Tokiota.Store.Demo.Infrastructure.Azure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.SqlServer;

    public class SqlAzureDbConfiguration : DbConfiguration
    {
        public SqlAzureDbConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(3, TimeSpan.FromSeconds(10)));
        }
    }
}
