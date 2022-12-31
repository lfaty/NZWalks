using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile: Profile
    {
        public RegionsProfile()
        {
            /* 
             // Methode 1 :  si la source et la destination nont pas les memes noms de variables 
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.RegionId));
            */

            //  Methode 2 : la source et la destination ont les memes de variables
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
        }
    }
}
