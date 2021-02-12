using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;

namespace MyTest.Models.ViewModels
{
    public class SalesRecordViewModel
    {
        public Seller Seller { get; set; }
        public List<SalesRecord> Sales { get; set; }
    }
}
