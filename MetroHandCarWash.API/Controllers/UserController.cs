using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Swashbuckle.Swagger.Annotations;
using Microsoft.AspNetCore.Mvc;
using MetroHandCarWash.API.Framework.Command;
using MetroHandCarWash.API.Framework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using MetroHandCarWash.API.Model;
using MetroHandCarWash.Domain;

namespace MetroHandCarWash.API.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly Logger _logger = LogManager.GetCurrentClassLogger();

        private readonly IMetroHandCarWashDomain _metroHandCarWashDomain;

        public UserController(IMetroHandCarWashDomain  metroHandCarWashDomain)
        {
            _metroHandCarWashDomain = metroHandCarWashDomain;
        }


        [HttpPost]
        [SwaggerResponse(200, type: typeof(string))]
        public async Task<IActionResult> RegisterNewClient(RegisterNewClientReq req)
        {
            if (req == null)
                return BadRequest();

            var response = await _metroHandCarWashDomain.RegisterNewClient(req.LastName,req.FirstName,req.Password,req.Email,req.Mobile,req.CreationDate,req.ModifiedDate);
            return Ok(response.ClientId);
        }

    }
}