using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpOption
{
    public decimal OptionId { get; set; }

    public string OptionName { get; set; } = null!;

    public string OptionValue { get; set; } = null!;

    public string Autoload { get; set; } = null!;
}
