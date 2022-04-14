using HolidayPlanner.Api.Command;
using HolidayPlanner.Api.Entities;
using HolidayPlanner.Api.Queries;
using HolidayPlanner.Api.Responses;
using HolidayPlanner.Api.Wrappers;
using System;
using System.Collections.Generic;

namespace HolidayPlanner.Api.Interfaces
{
    public interface IHolidayFormService
    {
        List<GetHolidayFormResponse> GetAll(GetHolidayFormQuery query);
        GetHolidayFormResponse GetById(Guid holidayRequestId);
        
        
        Result CreateHolidayRequest(CreateHolidayFormCommand command);
        Result UpdateHolidayRequest(UpdateHolidayFormCommand command);
        void ResetDatabase();
    }
}
