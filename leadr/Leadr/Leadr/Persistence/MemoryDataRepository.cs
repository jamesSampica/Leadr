using Leadr.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leadr.Persistence
{
    public interface IDataRepository
    {
        Task CreateAsync<TModel>(TModel model) where TModel : IDomainModel;

        Task DeleteAsync(int id);

        Task<IEnumerable<TModel>> GetAll<TModel>() where TModel : IDomainModel;
    }

    public class MemoryDataRepository : IDataRepository
    {
        public Task CreateAsync<TModel>(TModel model) where TModel : IDomainModel
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAll<TModel>() where TModel : IDomainModel
        {
            throw new System.NotImplementedException();
        }
    }
}
