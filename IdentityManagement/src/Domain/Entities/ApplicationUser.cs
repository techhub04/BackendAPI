﻿
namespace IdentityManagement.Domain.Entities
{
    public class ApplicationUser: BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }      
    }
}
