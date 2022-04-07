using HolidayPlanner.Api.Command;
using HolidayPlanner.Api.Entities;
using HolidayPlanner.Api.Queries;
using HolidayPlanner.Api.Responses;
using System;
using System.Collections.Generic;

namespace HolidayPlanner.Api.Interfaces
{
    public interface IHolidayFormService
    {
        List<GetHolidayFormResponse> GetAll(GetHolidayFormQuery query);
        GetHolidayFormResponse GetById(Guid holidayRequestId);
        string CreateHolidayRequest(CreateHolidayFormCommand command);
        string UpdateHolidayRequest(UpdateHolidayFormCommand command);
    }
}
