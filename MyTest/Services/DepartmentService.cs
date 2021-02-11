using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Data;
using MyTest.Models;
using Microsoft.EntityFrameworkCore;

namespace MyTest.Services
{
    public class DepartmentService
    {
        private readonly MyTestContext _context;

        public DepartmentService(MyTestContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.ToListAsync();
        }
    }
}
