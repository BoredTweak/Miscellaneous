using GraphQL;
using GraphQL.Types;

namespace webapi
{
    public class ToxicityMutation : ObjectGraphType
    {
        public ToxicityMutation(ToxicityData data)
        {
            Name = "Mutation";

            Field<ToxicityAnnotationType>(
                "createAnnotation",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ToxicityAnnotationInputType>> {Name = "toxicity_annotation"}
                ),
                resolve: context =>
                {
                    var arg = context.GetArgument<ToxicityAnnotation>("toxicity_annotation");
                    return data.AddToxicityAnnotation(arg);
                });
        }
    }
}
