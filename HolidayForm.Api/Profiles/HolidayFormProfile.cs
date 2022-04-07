using AutoMapper;
using HolidayPlanner.Api.Entities;
using HolidayPlanner.Api.Enums;
using HolidayPlanner.Api.Responses;
using System;

namespace HolidayPlanner.Api.Profiles
{
    public class HolidayFormProfile : Profile
    {
        public HolidayFormProfile()
        {
            // entity => dto
            CreateMap<HolidayForm, GetHolidayFormResponse>();

            // dto => entity
            CreateMap<CreateHolidayFormCommand, HolidayForm>()
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => nameof(State.Pending)))
                .ForMember(dest => dest.RequestedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.TotalDays, opt => opt.MapFrom(src => src.FlexibleHolidayAmount + src.VacationDayAmount));
        }
    }
}
