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

    [HttpGet("List/ByCityId")]
    [ProducesResponseType(typeof(IEnumerable<CityDistrictDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetListByCityIdAsync([FromQuery, BindRequired] GetCityDistrictListByCityIdQuery query)
        => Ok(await _mediator.Send(query));
}
