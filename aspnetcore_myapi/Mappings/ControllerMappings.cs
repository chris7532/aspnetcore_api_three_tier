using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_myapi.Models;
using aspnetcore_myapi.Models.Parameter;
using aspnetcore_myapi.Service.Dtos;
using AutoMapper;

namespace aspnetcore_myapi.Mappings
{
    public class ControllerMappings : Profile
    {
        public ControllerMappings()
        {
            // Parameter -> Info
            this.CreateMap<CardParameter, CardInfo>();
            this.CreateMap<CardSearchParameter, CardSearchInfo>();

            // ResultModel -> ViewModel
            this.CreateMap<CardResultModel, CardViewModel>();
        }
    }
}