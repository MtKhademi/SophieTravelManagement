using Microsoft.AspNetCore.Mvc;
using SophieTravelManagement.Application.Dtos;
using SophieTravelManagement.Application.Queries;
using SophieTravelManagement.Shared.Abstraction.Commands;
using SophieTravelManagement.Shared.Abstraction.Quesries;

namespace SophieTravelManagement.Api.Controllers
{
    public class TravelerCheckListController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public TravelerCheckListController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<TravelerCheckListDto>> Get([FromRoute] GetTravelerCheckList query)
        {
            var result = await _queryDispatcher.QueryAsync(query);
            return Ok(result);
        }


    }
}
