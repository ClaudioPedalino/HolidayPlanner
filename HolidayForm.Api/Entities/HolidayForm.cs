using System;
using System.ComponentModel.DataAnnotations;

namespace HolidayPlanner.Api.Entities
{
    public class HolidayForm
    {
        private int totalDays;

        [Key]
        public Guid Id { get; set; }
        public string RequestBy { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string State { get; set; }
        public int FlexibleHolidayAmount { get; set; }
        public int VacationDayAmount { get; set; }
        public DateTime RequestedDate { get; set; }
        public string EmployeeSignatureUrl { get; set; }


        public int TotalDays
        {
            get { return FlexibleHolidayAmount + VacationDayAmount; }
            set { totalDays = FlexibleHolidayAmount + VacationDayAmount; }
        }
    }
}
