using AutoMapper;
using LearnMore.Data.Entities;
using LearnMore.Domain.Models;

namespace LearnMore.Api.Mappers.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Registration, AppUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email));
        }
    }
}
