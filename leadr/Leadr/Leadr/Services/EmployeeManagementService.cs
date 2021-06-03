using Leadr.Domain.Models;
using Leadr.Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Leadr.Services
{
    public interface IEmployeeManagementService
    {
        Task<int> CreateEmployeeAsync(string name, string title, int[] managerIds);

        Task DeleteEmployeeAsync(int employeeId);

        Task<bool> NameExistsAsync(string name);
    }

    public class EmployeeManagementService : IEmployeeManagementService
    {
        private readonly IDataRepository _dataRepository;
        public EmployeeManagementService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<int> CreateEmployeeAsync(string name, string title, int[] managerIds)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> NameExistsAsync(string name)
        {
            return (await _dataRepository.GetAll<Employee>()).Any(e => e.Name == name);
        }
    }
}
