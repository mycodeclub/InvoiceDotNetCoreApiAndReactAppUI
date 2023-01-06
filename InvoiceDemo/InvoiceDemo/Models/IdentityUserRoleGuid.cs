using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class IdentityUserRoleGuid
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }
}
