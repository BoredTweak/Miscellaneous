using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;

namespace webapi
{
    public class ToxicityData
    {
        private readonly List<ToxicityAnnotation> _data = new List<ToxicityAnnotation>();

        public ToxicityData()
        {
            _data.Add(new ToxicityAnnotation
            {
                rev_id = "1",
                worker_id = "Luke",
                toxicity = 1M,
                toxicity_score = 2.0M
            });
            _data.Add(new ToxicityAnnotation
            {
                rev_id = "2",
                worker_id = "Vader",
                toxicity = 0M,
                toxicity_score = 1.0M
            });
        }

        public Task<ToxicityAnnotation> GetDataByIdAsync(string id)
        {
            return Task.FromResult(_data.FirstOrDefault(h => h.rev_id == id));
        }

        public ToxicityAnnotation AddToxicityAnnotation(ToxicityAnnotation input)
        {
            input.rev_id = Guid.NewGuid().ToString();
            _data.Add(input);
            return input;
        }
    }
}
