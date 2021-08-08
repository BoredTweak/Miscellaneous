using GraphQL.Types;

namespace webapi
{
    public class ToxicityAnnotationInterface : InterfaceGraphType<ToxicityAnnotation>
    {
        public ToxicityAnnotationInterface()
        {
            Name = "ToxicityAnnotation";

            Field(d => d.rev_id).Description("Rev Id.");
            Field(d => d.worker_id).Description("Worker Id.");
            Field(d => d.toxicity).Description("Is the item toxic?");
            Field(d => d.toxicity_score).Description("How toxic is the item?");
        }
    }
}
