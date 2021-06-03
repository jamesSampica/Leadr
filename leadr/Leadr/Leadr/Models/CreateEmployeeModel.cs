using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leadr.Models
{
    public class CreateEmployeeModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public IEnumerable<int> ManagerIds { get; set; }
    }
}
