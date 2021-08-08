using GraphQL.Types;

namespace webapi
{
    public class ToxicityAnnotationInterface : InterfaceGraphType<ToxicityAnnotations>
    {
        public ToxicityAnnotationInterface()
        {
            Name = "ToxicityAnnotations";

            Field(d => d.RevId, nullable:true).Description("Rev Id.");
            Field(d => d.WorkerId, nullable:true).Description("Worker Id.");
            Field(d => d.Toxicity, nullable:true).Description("Is the item toxic?");
            Field(d => d.ToxicityScore, nullable:true).Description("How toxic is the item?");
        }
    }
}
