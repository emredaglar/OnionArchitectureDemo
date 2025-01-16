using Onion.Application.Features.CQRSDesignPattern.Commands;
using Onion.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRSDesignPattern.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly OnionContext _context;

        public RemoveCategoryCommandHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.CategoryId);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
