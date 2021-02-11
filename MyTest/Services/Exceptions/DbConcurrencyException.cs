using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyTest.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string messege) : base(messege)
        {
        }
    }
}
