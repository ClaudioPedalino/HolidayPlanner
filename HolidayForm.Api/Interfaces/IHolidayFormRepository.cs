using HolidayPlanner.Api.Entities;
using HolidayPlanner.Api.Enums;
using HolidayPlanner.Api.Queries;
using System;
using System.Collections.Generic;

namespace HolidayPlanner.Api.Interfaces
{
    public interface IHolidayFormRepository
    {
        List<HolidayForm> GetAll(GetHolidayFormQuery query);
        HolidayForm GetById(Guid holidayRequestId);
        string Create(HolidayForm entity);
        string UpdateState(HolidayForm entity, State state);
    }
}
