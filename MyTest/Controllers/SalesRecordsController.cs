using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Services;

namespace MyTest.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year,1,1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("YYYY-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("YYYY-MM-dd");
            var salesrecord =  await _salesRecordService.FindByDateAsync(minDate,maxDate);
            return View(salesrecord);
        }

        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
