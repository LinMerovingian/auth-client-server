namespace AuthClientServer.Storage
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IResourceStorage
    {
        Resource Add(Resource entity);
        Task<Resource> AddAsync(Resource entity);
        void AddRange(IEnumerable<Resource> entities);
        Task AddRangeAsync(IEnumerable<Resource> entities);
        IEnumerable<Resource> GetAll();
        Task<IEnumerable<Resource>> GetAllAsync();
        Resource Update(Resource entity);
        Task<Resource> UpdateAsync(Resource entity);
        void UpdateRange(IEnumerable<Resource> entities);
        Task UpdateRangeAsync(IEnumerable<Resource> entities);
        void Remove(Resource entity);
        Task RemoveAsync(Resource entity);
        void RemoveRange(IEnumerable<Resource> entities);
        Task RemoveRangeAsync(IEnumerable<Resource> entities);
    }
}
