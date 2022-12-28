using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpNhom
{
    public int IdNhom { get; set; }

    public string? TenNhom { get; set; }

    public int? IdNhomcha { get; set; }

    public int? Trangthai { get; set; }
}
