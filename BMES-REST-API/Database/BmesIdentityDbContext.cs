using BMES_REST_API.Models.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Database
{
    public class BmesIdentityDbContext : IdentityDbContext<User>
    {
        public BmesIdentityDbContext(DbContextOptions<BmesIdentityDbContext> options) : base(options) { }
    }
}
