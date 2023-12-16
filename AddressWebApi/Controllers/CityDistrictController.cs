using AddressWebApi.Models;
using AddressWebApi.Request.Query.CityDistrict;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityDistrictController : ControllerBase
{
    private readonly IMediator _mediator;

    public CityDistrictController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(typeof(CityDistrictDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByIdAsync([FromQuery, BindRequired] GetCityDistrictByIdQuery query)
        => Ok(await _mediator.Send(query));

    [HttpGet("List/ByName")]
    [ProducesResponseType(typeof(IEnumerable<CityDistrictDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetByNameAsync([FromQuery, BindRequired] GetCityDistrictListByNameQuery query)
        => Ok(await _mediator.Send(query));

    [HttpGet("List/ByCityId")]
    [ProducesResponseType(typeof(IEnumerable<CityDistrictDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetListByCityIdAsync([FromQuery, BindRequired] GetCityDistrictListByCityIdQuery query)
        => Ok(await _mediator.Send(query));
}
