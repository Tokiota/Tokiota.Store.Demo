namespace Tokiota.Store.Demo.Domain.Identity.Model
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string AdditionalLastName { get; set; }
    }
}