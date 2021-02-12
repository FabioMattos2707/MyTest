using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;
using MyTest.Data;
using Microsoft.EntityFrameworkCore;

namespace MyTest.Services
{
    public class SalesRecordService
    {
        private readonly MyTestContext _context;

        public SalesRecordService(MyTestContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate);
            }

            return await result.Include(obj => obj.Seller).Include(obj => obj.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();
        }
    }
}
