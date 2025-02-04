﻿using Adnc.Ord.Domain.Aggregates.OrderAggregate;

namespace Adnc.Ord.Application.AutoMapper;

public class OrdProfile : Profile
{
    public OrdProfile()
    {
        CreateMap(typeof(PagedModel<>), typeof(PageModelDto<>)).ForMember("XData", opt => opt.Ignore());

        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderDto.OrderItemDto>();
    }
}