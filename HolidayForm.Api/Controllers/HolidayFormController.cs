using HolidayPlanner.Api.Command;
using HolidayPlanner.Api.Helpers;
using HolidayPlanner.Api.Interfaces;
using HolidayPlanner.Api.Queries;
using HolidayPlanner.Api.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HolidayPlanner.Api.Controllers
{
    [ApiController]
    [Route("api/holiday-request")]
    public class HolidayFormController : ControllerBase
    {
        private readonly IHolidayFormService _holidayRequestService;

        public HolidayFormController(IHolidayFormService holidayRequestService)
        {
            _holidayRequestService = holidayRequestService;
        }


        [HttpGet]
        public ActionResult GetAll([FromQuery] GetHolidayFormQuery query)
        {
            var result = _holidayRequestService.GetAll(query);

            return Ok(new { Result = result });
        }


        [HttpPost]
        //public ActionResult Create([FromBody] CreateHolidayFormCommand command)
        public ActionResult Create([FromForm] CreateHolidayFormCommand command)
        {
            Printer.PrintJsonInConsole(command);

            var result = _holidayRequestService.CreateHolidayRequest(command);

            return Ok(new { Result = result });
        }


        [HttpPut]
        public ActionResult ApproveHolidayRequest([FromBody] UpdateHolidayFormCommand command)
        {
            Printer.PrintJsonInConsole(command);

            var result = _holidayRequestService.UpdateHolidayRequest(command);

            return Ok(new { Result = result });
        }
    }




   
}
