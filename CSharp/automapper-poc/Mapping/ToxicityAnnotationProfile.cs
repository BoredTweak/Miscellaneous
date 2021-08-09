using AutoMapper;

namespace automapper_poc
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
