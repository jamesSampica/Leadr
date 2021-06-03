using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leadr.Services
{
    public interface IOrganizationService
    {
        Task GetOrganizationChart();
    }

    public class OrganizationService : IOrganizationService
    {
        public OrganizationService()
        {

        }

        public Task GetOrganizationChart()
        {
            throw new NotImplementedException();
        }
    }
}
