using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Services;
using Microsoft.AspNetCore.Mvc;

namespace Engrana.Controllers;

/// <summary>
/// Generic controller to handle basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="service"></param>
[ApiController]
[Route("v1/[controller]")]
public abstract class GenericController<T>(ServiceBase<T> service, IBackgroundTaskQueue taskQueue)
    : ControllerBase
    where T : EntityBase
{
    private readonly ServiceBase<T> _service = service;
    private readonly IBackgroundTaskQueue _taskQueue = taskQueue;

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
                await _taskQueue.QueueBackgroundWorkItemAsync(
                    async (serviceProvider, token) =>
                    {
                        var scopedService = serviceProvider.GetRequiredService<IService<T>>();
                        await scopedService.CheckEntityWorkflows(entity, ActionType.OnRead);
                    }
                );

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
                await _taskQueue.QueueBackgroundWorkItemAsync(
                    async (serviceProvider, token) =>
                    {
                        var scopedService = serviceProvider.GetRequiredService<IService<T>>();
                        await scopedService.CheckEntityWorkflows(entity, ActionType.OnChanged);
                    }
                );
                return StatusCode(
                    StatusCodes.Status204NoContent,
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
                await _taskQueue.QueueBackgroundWorkItemAsync(
                    async (serviceProvider, token) =>
                    {
                        var scopedService = serviceProvider.GetRequiredService<IService<T>>();
                        await scopedService.CheckEntityWorkflows(entity, ActionType.OnAdded);
                    }
                );

                return StatusCode(
                    StatusCodes.Status201Created,
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
            Guid guid = Guid.Parse(id);
            int result = await _service.DeleteAsync(guid);

            if (result > 0)
            {
                await _taskQueue.QueueBackgroundWorkItemAsync(
                    async (serviceProvider, token) =>
                    {
                        var scopedService = serviceProvider.GetRequiredService<IService<T>>();
                        await scopedService.CheckEntityWorkflows(guid, ActionType.OnDeleted);
                    }
                );
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
