using Azure.Core;
using DBExporter.DatabaseBuilders.SqlServer;
using DBExporter.DatabaseObjects;
using DBExporter.Options;

namespace DBExporter.DatabaseBuilders
{
    public class DatabaseBuilderFactory
    {
        public static IExportSourceBuilder? Connect(ServerTypes serverType, string connectionString) 
        {
            return serverType switch
            {
                ServerTypes.SqlServer => new SqlServerDatabaseBuilder(connectionString),
                _ => null,
            };

            // Lệnh return bên trên tương tự như lệnh switch bên dưới 
            // Trường hợp có nhiều kiểu database như postgresql, sqlServer, oracle, .. thì ta có thể tạo DatabaseBuilder tương ứng

            //switch (serverType) 
            //{
            //    case ServerTypes.SqlServer:
            //        return new SqlServerDatabaseBuilder(connectionString);
            //    default:
            //        return null;
            //}

        }
    }
}
