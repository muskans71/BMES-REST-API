using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Models.Shared
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
