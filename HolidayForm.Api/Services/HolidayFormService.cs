using AutoMapper;
using HolidayPlanner.Api.Command;
using HolidayPlanner.Api.Entities;
using HolidayPlanner.Api.Enums;
using HolidayPlanner.Api.Interfaces;
using HolidayPlanner.Api.Queries;
using HolidayPlanner.Api.Responses;
using System;
using System.Collections.Generic;

namespace HolidayPlanner.Api.Services
{
    public class HolidayFormService : IHolidayFormService
    {
        private readonly IHolidayFormRepository _holidayRequestRepository;
        private readonly IMapper _mapper;
        

        public HolidayFormService(IHolidayFormRepository holidayRequestRepository, IMapper mapper)
        {
            _holidayRequestRepository = holidayRequestRepository;
            _mapper = mapper;
        }


        public List<GetHolidayFormResponse> GetAll(GetHolidayFormQuery query)
        {
            var result = _holidayRequestRepository.GetAll(query);

            var response = _mapper.Map<List<GetHolidayFormResponse>>(result);

            return response;
        }


        public GetHolidayFormResponse GetById(Guid holidayRequestId)
        {
            var result = _holidayRequestRepository.GetById(holidayRequestId);

            var response = _mapper.Map<GetHolidayFormResponse>(result);

            return response;
        }


        public string CreateHolidayRequest(CreateHolidayFormCommand command)
        {
            var entity = _mapper.Map<HolidayForm>(command);

            _holidayRequestRepository.Create(entity);
            return "okido";
        }



        public string UpdateHolidayRequest(UpdateHolidayFormCommand command)
        {
            var result = _holidayRequestRepository.GetById(command.HolidayRequestId);

            if (result is null)
            {
                return "not found";
            }

            _holidayRequestRepository.UpdateState(result, command.State);


            return "okido";
        }
    }
}
