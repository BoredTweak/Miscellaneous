using System;
using GraphQL;
using GraphQL.Types;

namespace webapi
{
    /// <example>
    /// {
    ///   toxicity_annotation(rev_id: "2") {
    ///     worker_id
    ///   }
    /// }
    /// </example>
    public class ToxicityQuery : ObjectGraphType<object>
    {
        public ToxicityQuery(ToxicityData data)
        {
            Name = "Query";

            Field<ToxicityAnnotationType>(
                "toxicity_annotation",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "rev_id", Description = "id of the toxicity annotation" }
                ),
                resolve: context => data.GetDataByIdAsync(context.GetArgument<decimal>("rev_id"))
            );
        }
    }
}
