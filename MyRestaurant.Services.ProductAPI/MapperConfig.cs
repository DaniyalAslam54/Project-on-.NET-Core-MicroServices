using AutoMapper;
using MyRestaurant.Services.ProductAPI.Models;
using MyRestaurant.Services.ProductAPI.Models.DTO;

namespace MyRestaurant.Services.ProductAPI
{
    public class MapperConfig
    {
         public static MapperConfiguration RegisterMap()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
                }              
            ); 
            return mappingConfig;
        }
    }
}
