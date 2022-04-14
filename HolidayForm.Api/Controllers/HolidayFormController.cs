using HolidayPlanner.Api.Command;
using HolidayPlanner.Api.Interfaces;
using HolidayPlanner.Api.Queries;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Create([FromForm] CreateHolidayFormCommand command)
        {
            //Printer.PrintJsonInConsole(command);

            var result = _holidayRequestService.CreateHolidayRequest(command);

            return result.IsSuccess
                ? Ok(result)
                : BadRequest(result);
        }


        [HttpPut]
        public ActionResult ApproveHolidayRequest([FromBody] UpdateHolidayFormCommand command)
        {
            //Printer.PrintJsonInConsole(command);

            var result = _holidayRequestService.UpdateHolidayRequest(command);

            return result.IsSuccess
                ? Ok(result)
                : BadRequest(result);
        }



        [HttpDelete]
        public ActionResult DeleteAll()
        {
            if (Request.Headers["password"] == "pepe123")
            {
                _holidayRequestService.ResetDatabase();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }





}
