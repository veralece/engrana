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
        try
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
                new ApiResult<IEnumerable<T>>() { Successful = false, Message = "No items exist." }
            );
        }
        catch (SystemException)
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ApiResult<T>() { Successful = false, Message = "Server error." }
            );
        }
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<ApiResult<T>>> GetSingle([FromRoute] string id)
    {
        try
        {
            T? entity = await _service.GetByIdAsync(Guid.Parse(id));

            if (entity != null)
            {
                return StatusCode(
                    StatusCodes.Status200OK,
                    new ApiResult<T>(entity) { Successful = true }
                );
            }

            return StatusCode(
                StatusCodes.Status404NotFound,
                new ApiResult<T>() { Successful = false }
            );
        }
        catch (FormatException)
        {
            return StatusCode(
                StatusCodes.Status400BadRequest,
                new ApiResult<T>() { Successful = false, Message = "Incorrect format." }
            );
        }
        catch (SystemException)
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ApiResult<T>() { Successful = false, Message = "Server error." }
            );
        }
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<ApiResult<T>>> Put([FromRoute] string id, [FromBody] T entity)
    {
        try
        {
            int result = 0;

            if (Guid.Parse(id) == entity.Id)
                result = await _service.UpdateAsync(entity);

            if (result > 0)
            {
                return StatusCode(
                    StatusCodes.Status202Accepted,
                    new ApiResult<T>() { Successful = true }
                );
            }

            return StatusCode(
                StatusCodes.Status304NotModified,
                new ApiResult<T>() { Successful = false }
            );
        }
        catch (FormatException)
        {
            return StatusCode(
                StatusCodes.Status400BadRequest,
                new ApiResult<T>() { Successful = false, Message = "Incorrect format." }
            );
        }
        catch (SystemException)
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ApiResult<T>() { Successful = false, Message = "Server error." }
            );
        }
    }

    [HttpPost]
    public async Task<ActionResult<ApiResult<T>>> Post([FromBody] T entity)
    {
        try
        {
            T? result = await _service.AddAsync(entity);

            if (result != null)
            {
                return StatusCode(
                    StatusCodes.Status200OK,
                    new ApiResult<T>(result) { Successful = true }
                );
            }

            return StatusCode(
                StatusCodes.Status400BadRequest,
                new ApiResult<T>() { Successful = false }
            );
        }
        catch (SystemException)
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ApiResult<T>() { Successful = false, Message = "Server error." }
            );
        }
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult<ApiResult<T>>> Delete([FromRoute] string id)
    {
        try
        {
            int result = await _service.DeleteAsync(Guid.Parse(id));

            if (result > 0)
            {
                return StatusCode(
                    StatusCodes.Status200OK,
                    new ApiResult<T>() { Successful = true }
                );
            }

            return StatusCode(
                StatusCodes.Status404NotFound,
                new ApiResult<T>() { Successful = false }
            );
        }
        catch (FormatException)
        {
            return StatusCode(
                StatusCodes.Status400BadRequest,
                new ApiResult<T>() { Successful = false, Message = "Incorrect format." }
            );
        }
        catch (SystemException)
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ApiResult<T>() { Successful = false, Message = "Server error." }
            );
        }
    }
}
