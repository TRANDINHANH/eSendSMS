using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpTerm
{
    public decimal TermId { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public long TermGroup { get; set; }
}
