using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Data;
using MyTest.Models;

namespace MyTest.Services
{
    public class SellerService
    {
        private readonly MyTestContext _context;

        public SellerService(MyTestContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
