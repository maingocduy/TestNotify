using System;
using System.Collections.Generic;

namespace TestNotify.Databases.db;

public partial class Account
{
    public int Id { get; set; }

    public string Uuid { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? Created { get; set; }

    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 1:Đang hoạt động/0:bị khóa
    /// </summary>
    public int Status { get; set; }

    public virtual ICollection<NotifyAcc> NotifyAcc { get; set; } = new List<NotifyAcc>();
}
