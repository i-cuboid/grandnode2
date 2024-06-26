﻿using AutoMapper;
using Grand.Domain.Shipping;
using Grand.Infrastructure.Mapper;
using Grand.Web.Admin.Models.Shipping;

namespace Grand.Web.Admin.Mapper;

public class PickupPointProfile : Profile, IAutoMapperProfile
{
    public PickupPointProfile()
    {
        CreateMap<PickupPoint, PickupPointModel>()
            .ForMember(dest => dest.Address, mo => mo.MapFrom(y => y.Address));

        CreateMap<PickupPointModel, PickupPoint>()
            .ForMember(dest => dest.Id, mo => mo.Ignore());
    }

    public int Order => 0;
}