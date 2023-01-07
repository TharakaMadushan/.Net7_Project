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
            return _context.MasterEmployees.ToList();
        }

        public EmployeeMaster GetEmployeeById(int empNo)
        {
            return _context.MasterEmployees.Find(empNo);
        }
        public EmployeeMaster CreateEmployee(EmployeeMaster empNo)
        {
            _context.MasterEmployees.Add(empNo);
            _context.SaveChanges();

            return _context.MasterEmployees.Find(empNo.EmployeeNo);
        }

        public void UpdateEmployee(EmployeeMaster empNo)
        {
            _context.SaveChanges();
        }

        public void DeleteEmployee(EmployeeMaster empNo)
        {
            _context.Remove(empNo);
            _context.SaveChanges();
        }
    }
}
