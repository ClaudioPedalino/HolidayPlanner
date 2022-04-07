using System;

namespace HolidayPlanner.Api
{
    public class CreateHolidayFormCommand
    {
        public string RequestBy { get; init; }
        public string Department { get; init; }
        public string Position { get; init; }
        public int FlexibleHolidayAmount { get; init; }
        public int VacationDayAmount { get; init; }
        public DateTime DateFrom { get; init; }
        public DateTime DateTo { get; init; }

        //public IFormFile EmployeeSignature { get; init; }
        public string EmployeeSignatureUrl { get; init; }

    }
}
