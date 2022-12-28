using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpPostmetum
{
    public decimal MetaId { get; set; }

    public decimal PostId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
