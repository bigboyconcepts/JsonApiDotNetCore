using System;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiDotNetCoreExample.Models;
using Microsoft.Extensions.Logging;

namespace JsonApiDotNetCoreExample.Controllers
{
    public class TodoItemCollectionsController : JsonApiController<TodoItemCollection, Guid>
    {
         public TodoItemCollectionsController(
            IJsonApiContext jsonApiContext,
            IResourceService<TodoItemCollection, Guid> resourceService,
            ILoggerFactory loggerFactory) 
            : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}