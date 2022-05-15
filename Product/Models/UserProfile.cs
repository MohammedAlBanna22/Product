using AutoMapper;
using Product.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<FoodProduct,Products>().ReverseMap().ForMember(dest => dest.image, act => act.Ignore());
            CreateMap<Customor, appUsers>().ReverseMap();
            CreateMap<BlogView, Blogs>().ReverseMap();
        }
    }
}
