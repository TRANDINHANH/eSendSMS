using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpCommentmeta
{
    public decimal MetaId { get; set; }

    public decimal CommentId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
