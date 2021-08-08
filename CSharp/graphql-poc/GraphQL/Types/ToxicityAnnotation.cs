namespace webapi
{
    public class ToxicityAnnotation
    {
        public string rev_id { get; set; }
        public string worker_id { get; set; }
        public decimal toxicity { get; set; }
        public decimal toxicity_score { get; set; }
    }
}
