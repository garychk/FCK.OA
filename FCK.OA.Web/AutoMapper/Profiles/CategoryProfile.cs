using AutoMapper;
using FCK.OA.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FCK.OA.Web.AutoMapper.Profiles
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Categories, Dto.CategoryTree>();
        }
    }
}