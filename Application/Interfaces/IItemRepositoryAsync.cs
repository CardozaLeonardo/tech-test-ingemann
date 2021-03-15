using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IItemRepositoryAsync: IGenericRepositoryAsync<Item>
    {
        Task<Item> GetByCode(string code);
        Task<IReadOnlyList<Item>> GetAllActiveAsync();
    }
}