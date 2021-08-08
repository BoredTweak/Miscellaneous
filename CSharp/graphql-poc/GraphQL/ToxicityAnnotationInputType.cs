using GraphQL.Types;

namespace webapi
{
    public class ToxicityAnnotationInputType : InputObjectGraphType<ToxicityAnnotations>
    {
        public ToxicityAnnotationInputType()
        {
            Name = "ToxicityAnnotationInput";
            Field(x => x.RevId, nullable: true);
            Field(x => x.WorkerId, nullable: true);
            Field(x => x.Toxicity, nullable: true);
            Field(x => x.ToxicityScore, nullable: true);
        }
    }
}
