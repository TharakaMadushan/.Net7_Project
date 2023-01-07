using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MyHRMS.Common.ModelDTO;
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
        public ActionResult<ICollection<EmployeeDTO>> GetAllEmployees() 
        {
            var employees = _service.GetAllEmployees();
            var mappedEmployees = _mapper.Map<ICollection<EmployeeDTO>>(employees);
            return Ok(mappedEmployees);
        }
    }
}
