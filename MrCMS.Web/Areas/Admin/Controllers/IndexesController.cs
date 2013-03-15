﻿using System.Web.Mvc;
using MrCMS.Services;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Areas.Admin.Controllers
{
    public class IndexesController : MrCMSAdminController
    {
        private readonly IIndexService _indexService;

        public IndexesController(IIndexService indexService)
        {
            _indexService = indexService;
        }
        [HttpGet]
        public ViewResult Index()
        {
            return View(_indexService.GetIndexes());
        }

        [HttpPost]
        public RedirectToRouteResult Reindex(string type)
        {
            _indexService.Reindex(type);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToRouteResult Create(string type)
        {
            _indexService.Reindex(type);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToRouteResult Optimise(string type)
        {
            _indexService.Optimise(type);
            return RedirectToAction("Index");
        }
    }
}