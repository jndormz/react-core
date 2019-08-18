using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DormzReactCore.Configuration;
using DormzReactCore.Web;

namespace DormzReactCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DormzReactCoreDbContextFactory : IDesignTimeDbContextFactory<DormzReactCoreDbContext>
    {
        public DormzReactCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DormzReactCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DormzReactCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DormzReactCoreConsts.ConnectionStringName));

            return new DormzReactCoreDbContext(builder.Options);
        }
    }
}
