using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpTermmeta
{
    public decimal MetaId { get; set; }

    public decimal TermId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
