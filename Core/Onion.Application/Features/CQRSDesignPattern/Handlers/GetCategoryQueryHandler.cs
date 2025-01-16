using Microsoft.EntityFrameworkCore;
using Onion.Application.Features.CQRSDesignPattern.Results;
using Onion.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRSDesignPattern.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly OnionContext _context;

        public GetCategoryQueryHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values=await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
