using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DormzReactCore.EntityFrameworkCore
{
    public static class DormzReactCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DormzReactCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DormzReactCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
