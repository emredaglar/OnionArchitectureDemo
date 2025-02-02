using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Features.CQRSDesignPattern.Commands;
using Onion.Application.Features.CQRSDesignPattern.Handlers;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
                  
        public CategoryController(CreateCategoryCommandHandler createCommandHandler, UpdateCategoryCommandHandler updateCommandHandler, RemoveCategoryCommandHandler removeCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler)
        {
            _createCommandHandler = createCommandHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoryAsync()
        {
            return Ok(await _getCategoryQueryHandler.Handle());
        } 
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {

        }
    }
}
