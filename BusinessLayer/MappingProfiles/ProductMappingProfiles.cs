using AutoMapper;
using BusinessLayer.Dtos.Product;
using BusinessLayer.Dtos.Product.Requests;
using BusinessLayer.Dtos.Product.Responses;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.MappingProfiles
{
    public class ProductMappingProfiles : Profile
    {
        public ProductMappingProfiles()
        {
            CreateMap<Product, AddProductRequest>().ReverseMap();
            //.ForMember(i=>i.UnitPrice, opt => opt.MapFrom(dto => dto.Price));
            CreateMap<Product, ListProductResponse>().ReverseMap();
        }
    }
}