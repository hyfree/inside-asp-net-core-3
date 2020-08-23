using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App
{
    public class Role
    {
        public string RoleName { get; set; }
        public string NormalizedRoleName { get; set; }
        public virtual ICollection<UserRole> Users { get; } = new List<UserRole>();

        public Role() { }
        public Role(string roleName)
        {
            RoleName = roleName;
            NormalizedRoleName = roleName.ToUpper();
        }
    }

}
