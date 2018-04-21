using AutoMapper;
using FCK.OA.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FCK.OA.Web.AutoMapper.Profiles
{
    public class ShipProfile : Profile
    {
        public ShipProfile()
        {
            CreateMap<ShipHead, Dto.ShipHdDto>();
            CreateMap<ShipHead, Dto.ShipHdOutput>();
            CreateMap<Dto.ShipHdOutput, ShipHead>();
            CreateMap<Part, Dto.PartSelect>();
            CreateMap<ShipDetail, Dto.ShipDetailOutput>();
            CreateMap<Affairs, Dto.AffairOutput>();
        }
    }
}