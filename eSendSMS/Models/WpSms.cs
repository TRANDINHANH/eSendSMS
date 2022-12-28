using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpSms
{
    public long IdSms { get; set; }

    public string Noidung { get; set; } = null!;

    public string FileDinhkem { get; set; } = null!;

    public string IdNguoigui { get; set; } = null!;

    public string NgayGui { get; set; } = null!;

    public int SoTn { get; set; }
}
