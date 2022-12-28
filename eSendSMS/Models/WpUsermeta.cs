using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpUsermeta
{
    public decimal UmetaId { get; set; }

    public decimal UserId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
