using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Data;
using MyTest.Models;

namespace MyTest.Services
{
    public class DepartmentService
    {
        private readonly MyTestContext _context;

        public DepartmentService(MyTestContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.ToList();
        }
    }
}
