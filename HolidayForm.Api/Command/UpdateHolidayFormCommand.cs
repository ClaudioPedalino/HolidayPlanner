using HolidayPlanner.Api.Enums;
using System;

namespace HolidayPlanner.Api.Command
{
    public class UpdateHolidayFormCommand
    {
        public Guid HolidayRequestId { get; init; }
        public State State { get; init; }
    }
}
