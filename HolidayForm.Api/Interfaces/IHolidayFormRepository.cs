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
        
        void Create(HolidayForm entity);
        void UpdateState(HolidayForm entity, State state);
        void DeleteAllRecords();
    }
}
