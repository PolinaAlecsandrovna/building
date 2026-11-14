using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Учётные записи клиентов, менеджеров и администраторов
/// </summary>
public partial class AppUser
{
    public long UserId { get; set; }

    public short RoleId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string Login { get; set; } = null!;

    /// <summary>
    /// Пароль пользователя в открытом виде (по условию задания)
    /// </summary>
    public string Password { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? FullName { get; set; }

    public virtual Role Role { get; set; } = null!;
}
