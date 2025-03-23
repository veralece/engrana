using Engrana.Domain;
using Engrana.Service;
using Microsoft.AspNetCore.Mvc;

namespace Engrana.Controllers;

/// <summary>
/// Generic controller to handle basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="service"></param>
[ApiController]
[Route("v1/[controller]")]
public abstract class GenericController<T>(ServiceBase<T> service) : ControllerBase
    where T : EntityBase
{
    private readonly ServiceBase<T> _service = service;

    [HttpGet]
    public async Task<ActionResult<ApiResult<IEnumerable<T>>>> GetAll()
    {
        var entities = await _service.GetAllAsync();
        if (entities.Any())
        {
            return StatusCode(
                StatusCodes.Status200OK,
                new ApiResult<IEnumerable<T>>(entities) { Successful = true }
            );
        }

        return StatusCode(
            StatusCodes.Status404NotFound,
            new ApiResult<IEnumerable<T>>() { Successful = false }
        );
    }
}
