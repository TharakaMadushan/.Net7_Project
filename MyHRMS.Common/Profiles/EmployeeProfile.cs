using AutoMapper;
using MyHRMS.Common.ModelDTO;
using MyHRMS.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHRMS.Common.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeMaster, EmployeeDTO>().ForMember(dest => dest.EmployeeFullName,
                 opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<CreateEmployeeDTO, EmployeeMaster>();
            CreateMap<UpdateEmployeeDTO, EmployeeMaster>();
        }
    }
}
