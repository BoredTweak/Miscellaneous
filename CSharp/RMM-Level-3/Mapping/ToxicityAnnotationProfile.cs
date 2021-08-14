using AutoMapper;
using Models;
using Infrastructure.Models;

namespace Mapping
{
    public class ToxicityAnnotationProfile : Profile
    {
        public ToxicityAnnotationProfile()
        {
            CreateMap<ToxicityAnnotation, ToxicityAnnotations>();
            CreateMap<ToxicityAnnotations, ToxicityAnnotation>();
        }
    }
}
