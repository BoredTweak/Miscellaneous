using System;
using System.Collections.Generic;

#nullable disable

namespace webapi
{
    public partial class ToxicityAnnotations
    {
        public decimal? RevId { get; set; }
        public decimal? WorkerId { get; set; }
        public decimal? Toxicity { get; set; }
        public decimal? ToxicityScore { get; set; }
    }
}
