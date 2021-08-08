using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;

namespace webapi
{
    public class ToxicityData
    {
        private readonly ToxicityContext _dbContext;

        public ToxicityData(ToxicityContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Task<ToxicityAnnotations> GetDataByIdAsync(decimal id)
        {
            return Task.FromResult(_dbContext.ToxicityAnnotations.FirstOrDefault(h => h.RevId == id));
        }

        public ToxicityAnnotations AddToxicityAnnotation(ToxicityAnnotations input)
        {
            _dbContext.Add(input);
            _dbContext.SaveChanges();
            return input;
        }
    }
}
