using System.Collections.Generic;

namespace Leadr.Domain.Models
{
    public class Employee : IDomainModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public IEnumerable<Employee> Managers { get; set; } = new HashSet<Employee>();
    }
}
