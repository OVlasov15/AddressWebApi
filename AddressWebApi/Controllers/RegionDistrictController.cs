using AddressWebApi.Models;
using AddressWebApi.Request.Query.Region;
using AddressWebApi.Request.Query.RegionDistrict;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegionDistrictController : ControllerBase
{
    private readonly IMediator _mediator;

    public RegionDistrictController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(typeof(RegionDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByIdAsync([FromQuery, BindRequired] GetRegionDistrictByIdQuery query)
        => Ok(await _mediator.Send(query));

    [HttpGet("List/ByName")]
    [ProducesResponseType(typeof(RegionDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByNameAsync([FromQuery, BindRequired] GetRegionDistrictListByNameQuery query)
        => Ok(await _mediator.Send(query));

    [HttpGet("List/ByRegionId")]
    [ProducesResponseType(typeof(IEnumerable<RegionDistrictDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByRegionIdAsync([FromQuery, BindRequired] GetRegionDistrictListByRegionIdQuery query)
        => Ok(await _mediator.Send(query));
}
