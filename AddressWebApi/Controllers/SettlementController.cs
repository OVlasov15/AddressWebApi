using AddressWebApi.Models;
using AddressWebApi.Request.Query.Settlement;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SettlementController : ControllerBase
{
    private readonly IMediator _mediator;

    public SettlementController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("List/ByRegionDistrictId")]
    [ProducesResponseType(typeof(IEnumerable<SettlementDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByRegionDistrictAsync([FromQuery, BindRequired] GetSettlementListByRegionDistrictIdQuery query)
        => Ok(await _mediator.Send(query));

    [HttpGet("List/ByName")]
    [ProducesResponseType(typeof(IEnumerable<SettlementDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByNameAsync([FromQuery, BindRequired] GetSettlementListByNameQuery query)
        => Ok(await _mediator.Send(query));
}