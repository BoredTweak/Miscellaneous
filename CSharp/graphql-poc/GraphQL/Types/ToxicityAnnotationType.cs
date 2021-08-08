using GraphQL.Types;

namespace webapi
{
    public class ToxicityAnnotationType : ObjectGraphType<ToxicityAnnotations>
    {
        public ToxicityAnnotationType(ToxicityData data)
        {
            Name = "ToxicityAnnotationType";
            Description = "A data point associating an id to a toxicity measurement.";

            Field(d => d.RevId, nullable: true).Description("Rev Id.");
            Field(d => d.WorkerId, nullable: true).Description("Worker Id.");
            Field(d => d.Toxicity, nullable: true).Description("Is the item toxic?");
            Field(d => d.ToxicityScore, nullable: true).Description("How toxic is the item?");

            Interface<ToxicityAnnotationInterface>();
        }
    }
}
