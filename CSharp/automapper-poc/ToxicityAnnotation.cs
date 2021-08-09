using System;

namespace automapper_poc
{
    public partial class ToxicityAnnotation
    {
        public decimal? RevId { get; set; }
        public decimal? WorkerId { get; set; }
        public decimal? Toxicity { get; set; }
        public decimal? ToxicityScore { get; set; }
    }
}
