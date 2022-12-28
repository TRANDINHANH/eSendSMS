using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpTermRelationship
{
    public decimal ObjectId { get; set; }

    public decimal TermTaxonomyId { get; set; }

    public int TermOrder { get; set; }
}
