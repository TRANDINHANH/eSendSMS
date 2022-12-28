using System;
using System.Collections.Generic;

namespace eSendSMS.Models;

public partial class WpTermTaxonomy
{
    public decimal TermTaxonomyId { get; set; }

    public decimal TermId { get; set; }

    public string Taxonomy { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Parent { get; set; }

    public long Count { get; set; }
}
