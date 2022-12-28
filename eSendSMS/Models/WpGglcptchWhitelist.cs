using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpGglcptchWhitelist
{
    public long Id { get; set; }

    public string Ip { get; set; } = null!;

    public long? IpFromInt { get; set; }

    public long? IpToInt { get; set; }

    public DateTime? AddTime { get; set; }
}
