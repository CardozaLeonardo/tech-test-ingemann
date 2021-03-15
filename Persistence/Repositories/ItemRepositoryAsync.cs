using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class ItemRepositoryAsync: GenericRepositoryAsync<Item>, IItemRepositoryAsync
    {
        private readonly DbSet<Item> _items;

        public ItemRepositoryAsync(AppDbContext dbContext) : base(dbContext)
        {
            _items = dbContext.Set<Item>();
        }

        public async Task<IReadOnlyList<Item>> GetAllActiveAsync()
        {
            return await _items.Where(i => i.Active == true).ToListAsync();
        }

        public async Task<Item> GetByCode(string code)
        {
            return await _items.Where(i => i.Code == code).FirstOrDefaultAsync();
        }
    }
}