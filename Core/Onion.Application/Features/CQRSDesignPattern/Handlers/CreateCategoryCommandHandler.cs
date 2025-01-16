using Onion.Application.Features.CQRSDesignPattern.Commands;
using Onion.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRSDesignPattern.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly OnionContext _context;

        public CreateCategoryCommandHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Domain.Entities.Category()
            {
                CategoryName = command.CategoryName
            });
            await _context.SaveChangesAsync();  
        }
    }
}
