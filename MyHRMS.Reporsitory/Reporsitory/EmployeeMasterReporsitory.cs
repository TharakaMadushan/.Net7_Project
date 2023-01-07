using MyHRMS.Common.ModelDTO;
using MyHRMS.Entity.Entity;
using MyHRMS.Entity.MyDbContext;
using MyHRMS.IReporsitory.IReporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHRMS.Reporsitory.Reporsitory
{
    public class EmployeeMasterReporsitory : IEmployeeMaster
    {
        private readonly MyDbContext _context = new MyDbContext();
        public List<EmployeeMaster> GetAllEmployees()
        {
            return _context.MasterEmployee.ToList();
        }
    }
}
