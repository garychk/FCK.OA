﻿using AutoMapper;
using FCK.OA.Application;
using FCK.OA.Dto;
using FCK.OA.EntityFramework.Model;
using FCK.OA.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FCK.OA.Web.Controllers
{
    [Filters.FilterCheckLogin]
    public class PartController : BaseController, IControllerBase<Part, long>
    {
        public JsonResult Del(long id)
        {
            throw new NotImplementedException();
        }

        public JsonResult GetPartSelect(int page, int pageSize, string keywords)
        {
            ResultDto<List<PartSelect>> result = new ResultDto<List<PartSelect>>();
            PartService ObjServ = new PartService();
            var lists = ObjServ.Reposity.GetPageList(page, pageSize, o => o.PartNum.Contains(keywords) || o.PartDesc.Contains(keywords));
            result = Mapper.Map<ResultDto<List<PartSelect>>>(lists);
            ObjServ.Dispose();
            return Json(result);
        }

        public JsonResult GetModel(long id)
        {
            throw new NotImplementedException();
        }
        [Filters.FilterCheckPower]
        public ActionResult Index()
        {
            return View();
        }
        [Filters.FilterCheckPower]
        public ActionResult SyncERP()
        {
            return View();
        }

        public JsonResult InsertOrUpdate(Part input)
        {
            throw new NotImplementedException();
        }

        public JsonResult GetLists(int page, int pageSize, string keywords)
        {
            throw new NotImplementedException();
        }
    }
}