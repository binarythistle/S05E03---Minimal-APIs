using AutoMapper;
using SixAPI.Dtos;
using SixAPI.Models;

namespace SixAPI.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
     
            CreateMap<PlatformCreateDto, Platform>();
                    }
    }
}