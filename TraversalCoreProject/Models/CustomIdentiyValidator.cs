using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
    public class CustomIdentiyValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code= "PasswordTooShort",
                Description=$"Passsword Min {length} be character"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = $"Password must be at least 1 uppercase character"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = $"Password must be at least 1 lowercase character"
            };
        }
    }
}
