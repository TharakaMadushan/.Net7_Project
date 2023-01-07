using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MyHRMS.Common.ModelDTO;
using MyHRMS.Entity.Entity;
using MyHRMS.IReporsitory.IReporsitory;

namespace MyHRMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterEmployeeController : ControllerBase
    {
        private readonly IEmployeeMaster _service;
        private readonly IMapper _mapper;

        public MasterEmployeeController(IEmployeeMaster service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<EmployeeDTO>> GetEmployee()
        {
            var employees = _service.GetAllEmployees();
            var mapped = _mapper.Map<ICollection<EmployeeDTO>>(employees);
            return Ok(mapped);
        }

        [HttpGet("{empNo}", Name = "GetEmployeeById")]
        public IActionResult GetEmployeeById(int empNo)
        {
            var employee = _service.GetEmployeeById(empNo);
            var mappedEmployee = _mapper.Map<EmployeeDTO>(employee);
            return Ok(mappedEmployee);
        }

        [HttpPost]
        public ActionResult<CreateEmployeeDTO> CreateEmployee(CreateEmployeeDTO emp)
        {
            var employee = _mapper.Map<EmployeeMaster>(emp);
            var createEmp = _service.CreateEmployee(employee);
            var authorForReturn = _mapper.Map<EmployeeDTO>(createEmp);

            return CreatedAtRoute("GetEmployeeById", new { empNo = authorForReturn.EmployeeNo }, authorForReturn);
        }

        [HttpPut("{empNo}")]
        public ActionResult<UpdateEmployeeDTO> UpdateEmployee(int empNo,UpdateEmployeeDTO update)
        {
            var employee = _service.GetEmployeeById(empNo);

            if (employee is null)
            {
                return NotFound();
            }

            _mapper.Map(update, employee);
            _service.UpdateEmployee(employee);

            return NoContent();
        }

        [HttpDelete("{empNo}")]
        public ActionResult DeleteEmployee (int empNo) 
        { 
            var employee = _service.GetEmployeeById(empNo);

            if (employee is null)
            {
                return NotFound();
            }

            _service.DeleteEmployee(employee);
            return NoContent(); 
        }

    }
}
