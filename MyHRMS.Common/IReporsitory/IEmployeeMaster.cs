using MyHRMS.Common.ModelDTO;
using MyHRMS.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHRMS.IReporsitory.IReporsitory
{
    public interface IEmployeeMaster
    {
        public List<EmployeeMaster> GetAllEmployees();
        public EmployeeMaster GetEmployeeById(int empNo);
        public EmployeeMaster CreateEmployee(EmployeeMaster emp);
        public void UpdateEmployee(EmployeeMaster empNo);
        public void DeleteEmployee(EmployeeMaster empNo);
    }
}
