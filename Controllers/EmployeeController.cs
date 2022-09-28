﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alliance.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alliance.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "John",
                MiddleName = "Hello",
                LastName = "Doe",
                Role = "Full Stack Dev",
                DateJoined = "5/21/2001",
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
                return NotFound("No employee with given ID");
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> Create(Employee employee)
        {
            employees.Add(employee);
            return Ok(employees);

        }

        [HttpPut]
        public async Task<ActionResult<List<Employee>>> Update(Employee employee)
        {
            var emp = employees.Find(e => e.Id == employee.Id);
            if (emp == null)
                return NotFound();
            emp.FirstName = employee.FirstName;
            emp.MiddleName = employee.MiddleName;
            emp.LastName = employee.LastName;
            emp.Role = employee.Role;
            emp.DateJoined = employee.DateJoined;

            return Ok(employees);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> Delete(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
                return BadRequest("Not Found");
            employees.Remove(employee);
            return Ok(employees);
        }

    }
}

