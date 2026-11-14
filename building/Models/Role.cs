using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Роли пользователей системы
/// </summary>
public partial class Role
{
    public short RoleId { get; set; }

    /// <summary>
    /// Системный код роли: client, manager, admin
    /// </summary>
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<AppUser> AppUsers { get; set; } = new List<AppUser>();
}
