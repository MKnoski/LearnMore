using AutoMapper;
using LearnMore.Data.Entities;
using LearnMore.Domain.Models.Test;

namespace LearnMore.Api.Mappers.Profiles
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<Test, TestEntity>();
        }
    }
}