﻿using System;
using System.Collections.Generic;
using TestEducationCenterUoW.Domain.Commons;
using TestEducationCenterUoW.Domain.Entities.Departments;
using TestEducationCenterUoW.Domain.Enums;

namespace TestEducationUow.Domain.Entities.Departments
{
    public class Employee : IAuditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<EmployeeSalary> EmployeeSalaries { get; set; }

        public void Update()
        {
            UpdatedAt = DateTime.Now;
            State = ItemState.Updated;
        }

        public void Create()
        {
            CreatedAt = DateTime.Now;
            State = ItemState.Created;
        }

        public void Delete()
        {
            State = ItemState.Deleted;
        }
    }
}
