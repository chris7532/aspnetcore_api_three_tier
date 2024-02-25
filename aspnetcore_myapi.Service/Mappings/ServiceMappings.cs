using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using aspnetcore_myapi.Repository.Dtos.Condition;
using aspnetcore_myapi.Repository.Dtos.DataModel;
using aspnetcore_myapi.Service.Dtos;
using AutoMapper;

namespace aspnetcore_myapi.Service.Mappings
{
    public class ServiceMappings : Profile
    {
        public ServiceMappings()
    {
        // Info -> Condition
        this.CreateMap<CardInfo, CardCondition>();
        this.CreateMap<CardSearchInfo, CardSearchCondition>();

        // DataModel -> ResultModel
        this.CreateMap<CardDataModel, CardResultModel>();
    }
    }
}