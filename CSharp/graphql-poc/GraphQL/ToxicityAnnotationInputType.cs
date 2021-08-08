using GraphQL.Types;

namespace webapi
{
    public class ToxicityAnnotationInputType : InputObjectGraphType<ToxicityAnnotation>
    {
        public ToxicityAnnotationInputType()
        {
            Name = "ToxicityAnnotationInput";
            Field(x => x.rev_id, nullable: true);
            Field(x => x.worker_id, nullable: true);
            Field(x => x.toxicity, nullable: true);
            Field(x => x.toxicity_score, nullable: true);
        }
    }
}
