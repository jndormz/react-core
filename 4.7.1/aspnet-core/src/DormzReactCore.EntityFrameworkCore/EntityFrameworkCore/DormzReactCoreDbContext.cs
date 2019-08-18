using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DormzReactCore.Authorization.Roles;
using DormzReactCore.Authorization.Users;
using DormzReactCore.MultiTenancy;
using DormzReactCore.Products;

namespace DormzReactCore.EntityFrameworkCore
{
    public class DormzReactCoreDbContext : AbpZeroDbContext<Tenant, Role, User, DormzReactCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Products { get; set; }

        public DormzReactCoreDbContext(DbContextOptions<DormzReactCoreDbContext> options)
            : base(options)
        {
        }
    }
}
