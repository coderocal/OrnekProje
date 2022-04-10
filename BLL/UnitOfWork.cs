using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnitOfWork
    {
        private static OrnekProjeContext _context;
        private static object _lock = new object();

        public static OrnekProjeContext Context
        {
            get {
                if (_context == null)
                {
                    _context = new OrnekProjeContext();
                }
                return _context; 
            }
        }

        public static int Save()
        {
            lock (_lock)
            {
                return _context.SaveChanges();
            }

        }

    }
}
