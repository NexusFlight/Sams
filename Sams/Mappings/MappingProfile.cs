using AutoMapper;
using Sams.Models;
using Sams.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Students, StudentsDto>()
                .ForMember(dto => dto.Convenors, opt => opt.MapFrom(x => x.StudentConvenors.Select(y => y.Convenor).ToList()))
                .ForMember(dto => dto.Engagements, opt => opt.MapFrom(x => x.StudentEngagements.Select(y => y.Engagement).ToList()))
                .ForMember(dto => dto.Societies, opt => opt.MapFrom(x => x.StudentSocieties.Select(y => y.Society).ToList()))
                .ForMember(dto => dto.Suggestions, opt => opt.MapFrom(x => x.StudentSuggestions.Select(y => y.Suggestion).ToList()));
            CreateMap<Convenors, ConvenorsDto>()
                .ForMember(dto => dto.Societys, opt => opt.MapFrom(x => x.SocietyConvenors.Select(y => y.Society).ToList()))
                .ForMember(dto => dto.Students, opt => opt.MapFrom(x => x.StudentConvenors.Select(y => y.Students).ToList()));
            CreateMap<Societys, SocietysDto>()
                .ForMember(dto => dto.Convenors, opt => opt.MapFrom(x => x.SocietyConvenors.Select(y => y.Convenor).ToList()))
                .ForMember(dto => dto.Students, opt => opt.MapFrom(x => x.StudentSocieties.Select(y => y.Students).ToList()));
            CreateMap<Suggestions, SuggestionsDto>()
                .ForMember(dto => dto.Students, opt => opt.MapFrom(x => x.StudentSuggestions.Select(y => y.Student).ToList()));
            CreateMap<Engagements, EngagementsDto>()
                .ForMember(dto => dto.Students, opt => opt.MapFrom(x => x.StudentEngagements.Select(y => y.Student).ToList()));
        }
    }
}
