using HolidayPlanner.Api.Data;
using HolidayPlanner.Api.Entities;
using HolidayPlanner.Api.Enums;
using HolidayPlanner.Api.Interfaces;
using HolidayPlanner.Api.Queries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HolidayPlanner.Api.Repositories
{
    public class HolidayFormRepository : IHolidayFormRepository
    {
        private readonly DataContext _dataContext;

        public HolidayFormRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public List<HolidayForm> GetAll(GetHolidayFormQuery query)
        {
            int take = query.Size > 0
                ? query.Size
                : 50;

            int skip = query.Page > 0
                ? (query.Page - 1) * take
                : 0;

            var data = _dataContext.HolidayForms
                .OrderBy(x => x.State)
                .ThenBy(x => x.RequestedDate)
                .ThenBy(x => x.DateFrom)
                .ThenBy(x => x.DateTo)
                .Skip(skip)
                .Take(take)
                .ToList();

            return data;
        }


        public HolidayForm GetById(Guid holidayRequestId)
        {
            var data = _dataContext.HolidayForms
                .FirstOrDefault(x => x.Id == holidayRequestId);

            return data;
        }


        public void Create(HolidayForm entity)
        {
            _dataContext.HolidayForms.Add(entity);
            _dataContext.SaveChanges();
        }


        public void UpdateState(HolidayForm entity, State state)
        {
            entity.State = state.ToString();

            _dataContext.Update(entity);
            _dataContext.SaveChanges();
        }


        public void DeleteAllRecords()
        {
            _dataContext.RemoveRange(_dataContext.HolidayForms);
            _dataContext.SaveChanges();
        }
    }
}
