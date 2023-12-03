using AutoMapper;
using ProySuministros.Business.Layer.DataContracts;
using ProySuministros.DataAccess.Layer.Models;

namespace ProySuministros.Business.Layer
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
