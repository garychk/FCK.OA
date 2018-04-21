using AutoMapper;
using FCK.OA.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FCK.OA.Web.AutoMapper.Profiles
{
    public class CompanyProfile: Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, Dto.CompanyDto>();
        }
    }
}