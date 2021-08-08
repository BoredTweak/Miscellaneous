using GraphQL.Types;

namespace webapi
{
    public class ToxicityAnnotationType : ObjectGraphType<ToxicityAnnotation>
    {
        public ToxicityAnnotationType(ToxicityData data)
        {
            Name = "ToxicityAnnotationType";
            Description = "A data point associating an id to a toxicity measurement.";

            Field(d => d.rev_id).Description("Rev Id.");
            Field(d => d.worker_id).Description("Worker Id.");
            Field(d => d.toxicity).Description("Is the item toxic?");
            Field(d => d.toxicity_score).Description("How toxic is the item?");

            Interface<ToxicityAnnotationInterface>();
        }
    }
}
