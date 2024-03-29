﻿using AutoMapper;
using TestEducationCenterUoW.Domain.Entities.Courses;
using TestEducationCenterUoW.Domain.Entities.Departments;
using TestEducationCenterUoW.Domain.Entities.Groups;
using TestEducationCenterUoW.Domain.Entities.Students;
using TestEducationCenterUoW.Domain.Entities.Teachers;
using TestEducationCenterUoW.Service.DTOs.Students;
using TestEducationUow.Domain.Entities.Departments;
using TestEducationUow.Service.DTOs.Courses;
using TestEducationUow.Service.DTOs.Departaments;
using TestEducationUow.Service.DTOs.Groups;
using TestEducationUow.Service.DTOs.Teachers;

namespace TestEducationUow.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentForCreationDto, Student>().ReverseMap();

            CreateMap<CourseForCreationDto, Course>().ReverseMap();

            CreateMap<TeacherForCreationDto, Teacher>().ReverseMap();

            CreateMap<EmployeeForCreationDto, Employee>().ReverseMap();
            CreateMap<EmployeeSalaryForCreationDto, EmployeeSalary>().ReverseMap();

            CreateMap<GroupForCreationDto, Group>().ReverseMap();
        }
    }
}
