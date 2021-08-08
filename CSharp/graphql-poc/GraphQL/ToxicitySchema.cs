using GraphQL.Types;
using GraphQL.Utilities;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace webapi
{
    public class ToxicitySchema : Schema
    {
        public ToxicitySchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<ToxicityQuery>();
            Mutation = provider.GetRequiredService<ToxicityMutation>();
        }
    }
}
