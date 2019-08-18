using Abp.Authorization;
using DormzReactCore.Authorization.Roles;
using DormzReactCore.Authorization.Users;

namespace DormzReactCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
