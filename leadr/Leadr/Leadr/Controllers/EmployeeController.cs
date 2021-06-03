using Leadr.Models;
using Leadr.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leadr.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeManagementService _employeeManagementService;
        public EmployeeController(IEmployeeManagementService employeeManagementService)
            => (_employeeManagementService) = (employeeManagementService);

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name)) 
                return BadRequest(new ErrorApiModel("Name is required when creating employees"));

            if (string.IsNullOrWhiteSpace(model.Title))
                return BadRequest(new ErrorApiModel("Title is required when creating employees"));

            if(await _employeeManagementService.NameExistsAsync(model.Name))
                return BadRequest(new ErrorApiModel("This employee already exists"));

            throw new NotImplementedException();
        }

        public Task<IActionResult> Delete(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
