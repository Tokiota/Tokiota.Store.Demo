namespace Tokiota.Store.Demo.Domain.Identity.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model;

    internal class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}