using AutoMapper;
using Store.Services.CouponAPI.Models;
using Store.Services.CouponAPI.Models.Dto;

namespace Store.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }

        internal IMapper CreateMapper()
        {
            throw new NotImplementedException();
        }
    }
}
