using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseErp.Identity.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = default!;
        public int BranchId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
